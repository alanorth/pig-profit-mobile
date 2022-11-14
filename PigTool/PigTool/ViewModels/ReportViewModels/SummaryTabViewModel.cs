using PigTool.Views;
using Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Linq;
using OxyPlot.Series;
using OxyPlot;
using OxyPlot.Axes;
using PigTool.Helpers;
using static PigTool.Helpers.ChartHelper;

namespace PigTool.ViewModels
{
    public class SummaryTabViewModel : LoggedInViewModel
    {
        public List<Row> fullList;
        public double totalPeriodRevenue;
        public double totalPeriodCost;
        public double totalPeriodDifference;

        private PlotModel simpleGraphModel { get; set; }

        
        public List<Row> FullList
        {
            get { return fullList; }
            set
            {
                fullList = value;
                OnPropertyChanged(nameof(FullList));
            }
        }
        public PlotModel SimpleGraphModel
        {
            get
            {
                return simpleGraphModel;
            }
            set
            {
                simpleGraphModel = value;
            }
        }

        public double TotalPeriodRevenue
        {
            get => totalPeriodRevenue;
            set
            {
                if (value != totalPeriodRevenue)
                {
                    totalPeriodRevenue = value;
                    OnPropertyChanged(nameof(TotalPeriodRevenue));
                }
            }
        }
        public double TotalPeriodCost
        {
            get => totalPeriodCost;
            set
            {
                if (value != totalPeriodCost)
                {
                    totalPeriodCost = value;
                    OnPropertyChanged(nameof(TotalPeriodCost));
                }
            }
        }
        public double TotalPeriodDifference
        {
            get => totalPeriodDifference;
            set
            {
                if (value != totalPeriodDifference)
                {
                    totalPeriodDifference = value;
                    OnPropertyChanged(nameof(TotalPeriodDifference));
                }
            }
        }


        public SummaryTabViewModel()
        {
            ConstructPage();
            
        }

        public async void ConstructPage()
        {
            // Get chart data and load variables
            ChartHelper chartHelper = new ChartHelper();
            var result = await chartHelper.GetData();
            FullList = result.Item1; // used by list view
            TotalPeriodRevenue = result.Item2;
            TotalPeriodCost = result.Item3;
            TotalPeriodDifference = result.Item4;

            SimpleGraphModel = await chartHelper.GenerateTotalsGraphModel(
                TotalPeriodRevenue,
                TotalPeriodCost,
                TotalPeriodDifference);
            OnPropertyChanged("GraphModel");
        }

    }
}
