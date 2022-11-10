using System;
using Xamarin.Forms;
using System.Linq;
using System.Windows.Input;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System.ComponentModel;

namespace PigTool.ViewModels.ReportViewModels
{
    public class AdvancedTabViewModel : LoggedInViewModel
    {
        private PlotModel graphModel { get; set; }

        public PlotModel GraphModel
        {
            get
            {
                return graphModel;
            }
            set
            {
                graphModel = value;
            }
        }

        public AdvancedTabViewModel()
        {
            GraphModel = new PlotModel();

            LoadBarChart();
        }

        public void LoadBarChart()
        {
            GraphModel = null;
            OnPropertyChanged("GraphModel");
            var model = new PlotModel {  };
            model.LegendOrientation = LegendOrientation.Vertical;
            model.LegendPlacement = LegendPlacement.Outside;
            model.LegendPosition = LegendPosition.RightMiddle;

            var barSeries = new ColumnSeries
            {
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "{0}",
                IsStacked = true,
                Title = "Test 1"
            };

            barSeries.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(33),
                Color = OxyColor.Parse("#3498db")
            });

            barSeries.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(196),
                Color = OxyColor.Parse("#2ecc71")
            });


            barSeries.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(152),
                Color = OxyColor.Parse("#9b59b6")
            });

            barSeries.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(62),
                Color = OxyColor.Parse("#34495e")
            });

            barSeries.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(68),
                Color = OxyColor.Parse("#e74c3c")
            });

            barSeries.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(101),
                Color = OxyColor.Parse("#f1c40f")
            });

            model.Series.Add(barSeries);




            var barSeries2 = new ColumnSeries
            {
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "{0}",
                IsStacked = true,
                Title = "Test 2"
            };

            barSeries2.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(100),
                Color = OxyColor.Parse("#3498db")
            });

            barSeries2.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(100),
                Color = OxyColor.Parse("#2ecc71")
            });


            barSeries2.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(100),
                Color = OxyColor.Parse("#9b59b6")
            });

            barSeries2.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(100),
                Color = OxyColor.Parse("#34495e")
            });

            barSeries2.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(100),
                Color = OxyColor.Parse("#e74c3c")
            });

            barSeries2.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(100),
                Color = OxyColor.Parse("#f1c40f")
            });


            model.Series.Add(barSeries2);


            String[] strNames = new String[] { "Rabbit", "Dog", "Cat", "Goldfish", "Hamster", "Birds" };
            model.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Bottom,
                Key = "Sample Data",
                ItemsSource = strNames,
                IsPanEnabled = false,
                IsZoomEnabled = false,
                Selectable = false,
            });

            GraphModel = model;
            OnPropertyChanged("GraphModel");
        }

    }
}
