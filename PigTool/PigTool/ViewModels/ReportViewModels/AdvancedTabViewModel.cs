using System;
using Xamarin.Forms;
using System.Linq;
using System.Windows.Input;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System.ComponentModel;
using System.Collections.Generic;

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

        private PlotModel simpleGraphModel { get; set; }

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

        public AdvancedTabViewModel()
        {
            GraphModel = new PlotModel();
            LoadBasicChart();
            LoadAdvancedBarChart();
        }

        public void LoadBasicChart()
        {
            SimpleGraphModel = null;
            OnPropertyChanged("SimpleGraphModel");
            var model = new PlotModel { };
            /*model.DefaultColors = new List<OxyColor>
            {
                OxyColor.Parse("#3498db"),
                OxyColor.Parse("#e56b65"),
            };*/

            #region Series 1
            var barSeries = new ColumnSeries
            {
               // LabelPlacement = LabelPlacement.,
                //LabelFormatString = "{0}",
                //Title = "Water Cost"
            };

            barSeries.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(100),
                Color = OxyColor.Parse("#bc4749")
            });

            barSeries.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(200),
                Color = OxyColor.Parse("#a7c957")
            });

            model.Series.Add(barSeries);
            #endregion

            String[] strNames = new String[] { "Total Cost", "Total Profit" };
            model.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Bottom,
                Key = "Simple Sample Data",
                ItemsSource = strNames,
                IsPanEnabled = false,
                IsZoomEnabled = false,
                Selectable = false,
            });

            SimpleGraphModel = model;
            OnPropertyChanged("GraphModel");
        }

        public void LoadAdvancedBarChart()
        {
            GraphModel = null;
            OnPropertyChanged("GraphModel");
            var model = new PlotModel {  };
            model.LegendOrientation = LegendOrientation.Vertical;
            model.LegendPlacement = LegendPlacement.Outside;
            model.LegendPosition = LegendPosition.RightMiddle;
            
            model.DefaultColors = new List<OxyColor>
            {
                OxyColor.Parse("#3498db"),
                OxyColor.Parse("#e56b65"),
                OxyColor.Parse("#efca58"),
                OxyColor.Parse("#5fc091")
            };


            #region Series 1
            var barSeries = new ColumnSeries
            {
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "{0}",
                IsStacked = true,
                Title = "Water Cost"
            };

            barSeries.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(33),
            });

            barSeries.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(196),
            });

            barSeries.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(152),
            });

            barSeries.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(62),
            });

            barSeries.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(68),
            });

            barSeries.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(101),
            });

            model.Series.Add(barSeries);
            #endregion

            #region Series 2
            var barSeries2 = new ColumnSeries
            {
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "{0}",
                IsStacked = true,
                Title = "Housing",
            };

            barSeries2.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(120),
            });

            barSeries2.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(130),
            });

            barSeries2.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(70),
            });

            barSeries2.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(50),
            });

            barSeries2.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(170),
            });

            barSeries2.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(100),
            });

            model.Series.Add(barSeries2);
            #endregion

            #region Series 3
            var barSeries3 = new ColumnSeries
            {
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "{0}",
                IsStacked = true,
                Title = "Labour",
            };

            barSeries3.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(100),
            });

            barSeries3.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(130),
            });

            barSeries3.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(100),
            });

            barSeries3.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(230),
            });

            barSeries3.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(50),
            });

            barSeries3.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(100),
            });

            model.Series.Add(barSeries3);
            #endregion

            #region Series 4
            var barSeries4 = new ColumnSeries
            {
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "{0}",
                IsStacked = true,
                Title = "Health Care",
            };

            barSeries4.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(20),
            });

            barSeries4.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(30),
            });

            barSeries4.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(40),
            });

            barSeries4.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(45),
            });

            barSeries4.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(40),
            });

            barSeries4.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(25),

            });

            model.Series.Add(barSeries4);
            #endregion

            String[] strNames = new String[] { "Apr", "May", "Jun", "Jul", "Aug", "Sep" };
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
