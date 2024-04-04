using System;
using System.ComponentModel;
using Xamarin.Forms;
using Azure.Storage.Blobs;
using System.IO;
using System.Threading.Tasks;
using Azure.Storage.Blobs.Models;
using System.Collections.Generic;
using Xamarin.Essentials;
using PigTool.Interfaces;
using PigTool.ViewModels.ReportViewModels;

namespace PigTool.Views
{
    public partial class BenchmarkingTab : ContentPage
    {
        BenchmarkingTabViewModel _viewModel;

        public BenchmarkingTab()
        {
            InitializeComponent();

            _viewModel = new BenchmarkingTabViewModel();

            BenchMarkingTitle.SetBinding(Label.TextProperty, nameof(_viewModel.BenchmarkingTabLable));
            this.BindingContext = _viewModel;
            this.Title = _viewModel.BenchmarkingTabLable;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.DisplayLoading = true;

            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                try
                {
                    bool isConnected = false;
                    string connectionString = await SecureStorage.GetAsync("BlobStorageConnectionString");
                    if (string.IsNullOrEmpty(connectionString))
                    {
                        connectionString = await _viewModel.RefreshStroageConnectonString();
                    }

                    BlobServiceClient blobServiceClient = null;
                    BlobContainerClient containerClient = null;
                    var attempts = 0;
                    while (!isConnected && attempts < 2)

                    {
                        try
                        {
                            blobServiceClient = new BlobServiceClient(connectionString);
                            containerClient = blobServiceClient.GetBlobContainerClient("app-reports");
                            isConnected = true;
                        }
                        catch (Exception ex)
                        {
                            attempts++;
                            connectionString = await _viewModel.RefreshStroageConnectonString();
                        }
                    }

                    if (containerClient != null)
                    {
                        _viewModel.DisplayLoading = false;
                        var blobs = new List<string>();
                        await foreach (BlobItem blobItem in containerClient.GetBlobsAsync())
                        {
                            blobs.Add(blobItem.Name);
                        }

                        BlobListView.ItemsSource = blobs;
                    }
                    else
                    {
                        _viewModel.DisplayLoading = false;
                        await DisplayAlert("Error", "No connection to the storage account", "OK");
                    }

                    
                }
                catch (Exception ex)
                {
                    _viewModel.DisplayLoading = false;
                    await DisplayAlert("Error", ex.Message, "OK");
                }
            }
            else
            {
                _viewModel.DisplayLoading = false;
                await DisplayAlert("No Internet", "No data connection available", "OK");
            }
            _viewModel.DisplayLoading = false;
        }

        public async Task DownloadPdfAsync(string blobName, string downloadPath)
        {
            try
            {
                string connectionString = await SecureStorage.GetAsync("BlobStorageConnectionString");
                BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);
                BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient("app-reports");

                BlobClient blobClient = containerClient.GetBlobClient(blobName);

                BlobDownloadInfo download = await blobClient.DownloadAsync();

                using (FileStream file = File.OpenWrite(downloadPath))
                {
                    await download.Content.CopyToAsync(file);
                }

                await Launcher.OpenAsync(new OpenFileRequest
                {
                    File = new ReadOnlyFile(downloadPath)
                });
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void OnBlobSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                string blobName = e.SelectedItem.ToString();
                string downloadFolder = DependencyService.Get<IFileService>().GetDownloadFolderPath();
                string downloadPath = Path.Combine(downloadFolder, blobName);

                await DownloadPdfAsync(blobName, downloadPath);
            }
        }
    }


}