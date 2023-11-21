using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using PigTool.Services;
using Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PigTool.Helpers
{
    public class ChartHelper
    {
        public IDataRepo repo;
        public List<Translation> TranslationStore;
        public event PropertyChangedEventHandler PropertyChanged;

        public List<Row> fullList;
        public double totalPeriodRevenue;
        public double totalPeriodCost;
        public double totalPeriodDifference;

        private ObservableCollection<FeedItem> feedItems;
        private ObservableCollection<HealthCareItem> healthCareItems;
        private ObservableCollection<PigSaleItem> pigSaleItems;
        private ObservableCollection<WaterCostItem> waterCostItems;
        private ObservableCollection<ReproductiveItem> reproductiveItems;
        private ObservableCollection<OtherIncomeItem> otherIncomeItems;
        private ObservableCollection<OtherCostItem> otherCostItems;
        private ObservableCollection<MembershipItem> membershipItems;
        private ObservableCollection<ManureSaleItem> manureSaleItems;
        private ObservableCollection<LoanRepaymentItem> loanRepaymentItems;
        private ObservableCollection<LabourCostItem> labourCostItems;
        private ObservableCollection<EquipmentItem> equipmentItems;
        private ObservableCollection<BreedingServiceSaleItem> breedServiceSaleItems;
        private ObservableCollection<AnimalPurchaseItem> animalPurchaseItems;
        private ObservableCollection<AnimalHouseItem> animalHouseItems;

        #region Variables
        public List<Row> FullList
        {
            get { return fullList; }
            set
            {
                fullList = value;
                OnPropertyChanged(nameof(FullList));
            }
        }

        #endregion

        #region Collections
        public ObservableCollection<AnimalHouseItem> AnimalHouseItems
        {

            get { return animalHouseItems; }
            set
            {
                animalHouseItems = value;
                OnPropertyChanged(nameof(AnimalHouseItems));
            }
        }
        public ObservableCollection<AnimalPurchaseItem> AnimalPurchaseItems
        {

            get { return animalPurchaseItems; }
            set
            {
                animalPurchaseItems = value;
                OnPropertyChanged(nameof(AnimalPurchaseItems));
            }
        }
        public ObservableCollection<BreedingServiceSaleItem> BreedServiceSaleItems
        {

            get { return breedServiceSaleItems; }
            set
            {
                breedServiceSaleItems = value;
                OnPropertyChanged(nameof(BreedServiceSaleItems));
            }
        }
        public ObservableCollection<EquipmentItem> EquipmentItems
        {

            get { return equipmentItems; }
            set
            {
                equipmentItems = value;
                OnPropertyChanged(nameof(EquipmentItems));
            }
        }
        public ObservableCollection<FeedItem> FeedItems
        {

            get { return feedItems; }
            set
            {
                feedItems = value;
                OnPropertyChanged(nameof(FeedItems));
            }
        }
        public ObservableCollection<HealthCareItem> HealthCareItems
        {

            get { return healthCareItems; }
            set
            {
                healthCareItems = value;
                OnPropertyChanged(nameof(HealthCareItems));
            }
        }
        public ObservableCollection<LabourCostItem> LabourCostItems
        {

            get { return labourCostItems; }
            set
            {
                labourCostItems = value;
                OnPropertyChanged(nameof(LabourCostItems));
            }
        }
        public ObservableCollection<LoanRepaymentItem> LoanRepaymentItems
        {

            get { return loanRepaymentItems; }
            set
            {
                loanRepaymentItems = value;
                OnPropertyChanged(nameof(LoanRepaymentItems));
            }
        }
        public ObservableCollection<ManureSaleItem> ManureSaleItems
        {

            get { return manureSaleItems; }
            set
            {
                manureSaleItems = value;
                OnPropertyChanged(nameof(ManureSaleItems));
            }
        }
        public ObservableCollection<MembershipItem> MembershipItems
        {

            get { return membershipItems; }
            set
            {
                membershipItems = value;
                OnPropertyChanged(nameof(MembershipItems));
            }
        }
        public ObservableCollection<OtherCostItem> OtherCostItems
        {

            get { return otherCostItems; }
            set
            {
                otherCostItems = value;
                OnPropertyChanged(nameof(OtherCostItems));
            }
        }
        public ObservableCollection<OtherIncomeItem> OtherIncomeItems
        {

            get { return otherIncomeItems; }
            set
            {
                otherIncomeItems = value;
                OnPropertyChanged(nameof(OtherIncomeItems));
            }
        }
        public ObservableCollection<PigSaleItem> PigSaleItems
        {

            get { return pigSaleItems; }
            set
            {
                pigSaleItems = value;
                OnPropertyChanged(nameof(PigSaleItems));
            }
        }
        #endregion
        public ObservableCollection<ReproductiveItem> ReproductiveItems
        {

            get { return reproductiveItems; }
            set
            {
                reproductiveItems = value;
                OnPropertyChanged(nameof(ReproductiveItems));
            }
        }
        public ObservableCollection<WaterCostItem> WaterCostItems
        {

            get { return waterCostItems; }
            set
            {
                waterCostItems = value;
                OnPropertyChanged(nameof(WaterCostItems));
            }
        }

        public class YearMonth : IEquatable<YearMonth>
        {
            public int Year { get; set; }
            public string Month { get; set; }
            public DateTime Date { get; set; }
            public string Grouping { get; set; }

            public override bool Equals(object other)
            {
                if (ReferenceEquals(null, other)) return false;
                if (ReferenceEquals(this, other)) return true;
                if (this.GetType() != other.GetType())
                    return false;
                return Equals((YearMonth)other);
            }

            public override int GetHashCode()
            {
                return Year.GetHashCode() + Month.GetHashCode();
            }

            public bool Equals(YearMonth other)
            {
                var result = (other.Month == Month
                    && other.Year == Year
                    && other.Date == Date);
                return result;
            }
        }

        public class Row
        {
            public YearMonth YearMonth { get; set; }
            public double? Cost { get; set; }
            public double? Revenue { get; set; }
            public double? Difference { get; set; }
        }

        public ChartHelper()
        {
            repo = DependencyService.Get<IDataRepo>();
            TranslationStore = repo.GetAllTranslations().Result;
        }

        public async Task<(List<Row>, double, double, double)> GetData()
        {
            // Initial grouping for Feed items
            FeedItems = new ObservableCollection<FeedItem>(await repo.GetFeedItems());
            fullList = getDurationFeedItems(FeedItems);

            //Initial grouping for Animalhouse Items
            AnimalHouseItems = new ObservableCollection<AnimalHouseItem>(await repo.GetAnimalHouseItems());
            fullList = fullList.Concat(getDurationHousingItmes(AnimalHouseItems)).ToList();
            /*fullList = fullList.Concat(AnimalHouseItems.GroupBy(fi => new YearMonth
            {
                Year = fi.Date.Year,
                Month = fi.Date.ToString("MMM"),
                Date = fi.Date,
                Grouping = nameof(AnimalHouseItem)
            }).Select(fi => new Row
            {
                YearMonth = fi.Key,
                Cost = fi.Sum(i => i.TotalCosts) + fi.Sum(i => i.TransportationCost) + fi.Sum(i => i.OtherCosts),
                Revenue = 0,
                Difference = 0
            }).ToList()).ToList();*/


            AnimalPurchaseItems = new ObservableCollection<AnimalPurchaseItem>(await repo.GetAnimalPurchaseItems());
            fullList = fullList.Concat(AnimalPurchaseItems.GroupBy(fi => new YearMonth
            {
                Year = fi.Date.Year,
                Month = fi.Date.ToString("MMM"),
                Date = fi.Date,
                Grouping = nameof(AnimalPurchaseItem)
            }).Select(fi => new Row
            {
                YearMonth = fi.Key,
                Cost = fi.Sum(i => i.TotalCosts) + fi.Sum(i => i.TransportationCost) + fi.Sum(i => i.OtherCosts),
                Revenue = 0,
                Difference = 0
            }).ToList()).ToList();

            BreedServiceSaleItems = new ObservableCollection<BreedingServiceSaleItem>(await repo.GetBreedingServiceSaleItems());
            fullList = fullList.Concat(BreedServiceSaleItems.GroupBy(fi => new YearMonth
            {
                Year = fi.Date.Year,
                Month = fi.Date.ToString("MMM"),
                Date = fi.Date,
                Grouping = nameof(BreedingServiceSaleItem)
            }).Select(fi => new Row
            {
                YearMonth = fi.Key,
                Cost = fi.Sum(i => i.TransportationCost) + fi.Sum(i => i.OtherCosts),
                Revenue = fi.Sum(i => i.AmountRecieved) + fi.Sum(i => i.PaymentValue),
                Difference = 0
            }).ToList()).ToList();

            EquipmentItems = new ObservableCollection<EquipmentItem>(await repo.GetEquipmentItems());
            fullList = fullList.Concat(EquipmentItems.GroupBy(fi => new YearMonth
            {
                Year = fi.Date.Year,
                Month = fi.Date.ToString("MMM"),
                Date = fi.Date,
                Grouping = nameof(EquipmentItem)
            }).Select(fi => new Row
            {
                YearMonth = fi.Key,
                Cost = fi.Sum(i => i.TotalCosts) + fi.Sum(i => i.TransportationCost) + fi.Sum(i => i.OtherCosts),
                Revenue = 0,
                Difference = 0
            }).ToList()).ToList();

            LabourCostItems = new ObservableCollection<LabourCostItem>(await repo.GetLabourCostItems()); ;
            fullList = fullList.Concat(getDurationLabourCost(LabourCostItems)).ToList();

            LoanRepaymentItems = new ObservableCollection<LoanRepaymentItem>(await repo.GetLoanRepaymentItems());
            fullList = fullList.Concat(getDurationLoanItems(LoanRepaymentItems)).ToList();

            ManureSaleItems = new ObservableCollection<ManureSaleItem>(await repo.GetManureSaleItems());
            fullList = fullList.Concat(ManureSaleItems.GroupBy(fi => new YearMonth
            {
                Year = fi.Date.Year,
                Month = fi.Date.ToString("MMM"),
                Date = fi.Date,
                Grouping = nameof(ManureSaleItem)
            }).Select(fi => new Row
            {
                YearMonth = fi.Key,
                Cost = fi.Sum(i => i.TransportationCost) + fi.Sum(i => i.OtherCosts),
                Revenue = fi.Sum(i => i.AmountRecieved),
                Difference = 0
            }).ToList()).ToList();

            MembershipItems = new ObservableCollection<MembershipItem>(await repo.GetMembershipItems());
            fullList = fullList.Concat(getDurationMembershipItems(MembershipItems)).ToList();

            OtherCostItems = new ObservableCollection<OtherCostItem>(await repo.GetOtherCostItems());
            fullList = fullList.Concat(OtherCostItems.GroupBy(fi => new YearMonth
            {
                Year = fi.Date.Year,
                Month = fi.Date.ToString("MMM"),
                Date = fi.Date,
                Grouping = nameof(OtherCostItem)
            }).Select(fi => new Row
            {
                YearMonth = fi.Key,
                Cost = fi.Sum(i => i.TotalCosts) + fi.Sum(i => i.TransportationCosts) + fi.Sum(i => i.OtherCosts),
                Revenue = 0,
                Difference = 0
            }).ToList()).ToList();

            OtherIncomeItems = new ObservableCollection<OtherIncomeItem>(await repo.GetOtherIncomeItems());
            fullList = fullList.Concat(OtherIncomeItems.GroupBy(fi => new YearMonth
            {
                Year = fi.Date.Year,
                Month = fi.Date.ToString("MMM"),
                Date = fi.Date,
                Grouping = nameof(OtherIncomeItem)
            }).Select(fi => new Row
            {
                YearMonth = fi.Key,
                Cost = fi.Sum(i => i.TransportationCosts) + fi.Sum(i => i.OtherCosts),
                Revenue = fi.Sum(i => i.TotalIncome),
                Difference = 0
            }).ToList()).ToList();


            // Appending Health care items to the full list grouped by YearMonth
            HealthCareItems = new ObservableCollection<HealthCareItem>(await repo.GetHealthCareItems());
            fullList = fullList.Concat(HealthCareItems.GroupBy(fi => new YearMonth
            {
                Year = fi.Date.Year,
                Month = fi.Date.ToString("MMM"),
                Date = fi.Date,
                Grouping = nameof(HealthCareItem)
            }).Select(fi => new Row
            {
                YearMonth = fi.Key,
                Cost = fi.Sum(i => i.HealthCareCost) + fi.Sum(i => i.MedicineCost)
                + fi.Sum(i => i.TransportationCost) + fi.Sum(i => i.OtherCosts),
                Revenue = 0,
                Difference = 0
            }).ToList()).ToList();

            PigSaleItems = new ObservableCollection<PigSaleItem>(await repo.GetPigSaleItems());
            fullList = fullList.Concat(PigSaleItems.GroupBy(fi => new YearMonth
            {
                Year = fi.Date.Year,
                Month = fi.Date.ToString("MMM"),
                Date = fi.Date,
                Grouping = nameof(PigSaleItem)
            }).Select(fi => new Row
            {
                YearMonth = fi.Key,
                Cost = fi.Sum(i => i.TransportationCost) + fi.Sum(i => i.OtherCosts),
                Revenue = fi.Sum(i => i.SalePrice),
                Difference = 0
            }).ToList()).ToList();

            WaterCostItems = new ObservableCollection<WaterCostItem>(await repo.GetWaterCostItems());
            fullList = fullList.Concat(getDurationWaterItems(WaterCostItems)).ToList();

            ReproductiveItems = new ObservableCollection<ReproductiveItem>(await repo.GetReproductiveItems());
            fullList = fullList.Concat(ReproductiveItems.GroupBy(fi => new YearMonth
            {
                Year = fi.Date.Year,
                Month = fi.Date.ToString("MMM"),
                Date = fi.Date,
                Grouping = nameof(ReproductiveItem)
            }).Select(fi => new Row
            {
                YearMonth = fi.Key,
                Cost = fi.Sum(i => i.SowsServicedCost) + fi.Sum(i => i.TransportCost) + fi.Sum(i => i.OtherCosts),
                Revenue = 0,
                Difference = 0
            }).ToList()).ToList();

            // Group fulllist once more into YearMonths and sort by year then month to get most recent first
            /*fullList = fullList.GroupBy(fl => new YearMonth
            {
                Year = fl.YearMonth.Year,
                Month = fl.YearMonth.Month,
            })
                .Select(fl => new Row
                {
                    YearMonth = fl.Key,
                    Cost = fl.Sum(i => i.Cost),
                    Revenue = fl.Sum(i => i.Revenue),
                    Difference = fl.Sum(i => i.Revenue) - fl.Sum(i => i.Cost)
                }).OrderByDescending(fl => fl.YearMonth.Year).ThenByDescending(fl => fl.YearMonth.Month).ToList();*/

            //Calculate totals
            totalPeriodCost = fullList.Sum(fl => (double)fl.Cost);
            totalPeriodRevenue = fullList.Sum(fl => (double)fl.Revenue);
            totalPeriodDifference = totalPeriodRevenue - totalPeriodCost;

            return (FullList, totalPeriodRevenue, totalPeriodCost, totalPeriodDifference);
        }

        public List<Row> getDurationFeedItems(ObservableCollection<FeedItem> FeedItems)
        {
            var result = new List<Row>();

            foreach (var feed in FeedItems)
            {
                var oCost = feed.OtherCosts == null ? 0 : feed.OtherCosts;
                var totalCost = feed.TotalCosts + oCost + feed.TransportationCost;
                var startDate = ((DateTime)feed.DurationStart);
                var DurationLength = (TimeSpan)(feed.DurationFinish - feed.DurationStart);
                CallculateDurtaionRows(result, totalCost, startDate, DurationLength, nameof(FeedItem));
            }

            return result;
        }


        public List<Row> getDurationHousingItmes(ObservableCollection<AnimalHouseItem> HouseItemss)
        {
            var result = new List<Row>();

            foreach (var house in HouseItemss)
            {
                //var oCost = house.DisplayTotalCosts;
                var totalCost = house.DisplayTotalCosts;
                var startDate = ((DateTime)house.DurationStart);
                var DurationLength = (TimeSpan)(house.DurationFinish - house.DurationStart);
                CallculateDurtaionRows(result, totalCost, startDate, DurationLength, nameof(AnimalHouseItem));
            }

            return result;
        }

        public List<Row> getDurationLabourCost(ObservableCollection<LabourCostItem> LabourCosts)
        {
            var result = new List<Row>();

            foreach (var labour in LabourCosts)
            {
                var oCost = labour.OtherCost == null ? 0 : labour.OtherCost;
                var totalCost = labour.AmountPaid + oCost;
                var startDate = ((DateTime)labour.DurationStart);
                var DurationLength = (TimeSpan)(labour.DurationFinish - labour.DurationStart);
                CallculateDurtaionRows(result, totalCost, startDate, DurationLength, nameof(LabourCostItem));
            }

            return result;
        }
        public List<Row> getDurationLoanItems(ObservableCollection<LoanRepaymentItem> LoanItems)
        {
            var result = new List<Row>();

            foreach (var loan in LoanItems)
            {
                var oCost = loan.OtherCosts == null ? 0 : loan.OtherCosts;
                var totalCost = loan.TotalAmountRepaid + oCost + loan.TransportCosts;
                var startDate = ((DateTime)loan.DurationStart);
                var DurationLength = (TimeSpan)(loan.DurationFinish - loan.DurationStart);
                CallculateDurtaionRows(result, totalCost, startDate, DurationLength, nameof(LoanRepaymentItem));
            }

            return result;
        }
        public List<Row> getDurationMembershipItems(ObservableCollection<MembershipItem> MembershipItems)
        {
            var result = new List<Row>();

            foreach (var member in MembershipItems)
            {
                var oCost = member.OtherCosts == null ? 0 : member.OtherCosts;
                var totalCost = member.TotalCosts + oCost;
                var startDate = ((DateTime)member.DurationStart);
                var DurationLength = (TimeSpan)(member.DurationFinish - member.DurationStart);
                CallculateDurtaionRows(result, totalCost, startDate, DurationLength, nameof(MembershipItem));
            }

            return result;
        }
        public List<Row> getDurationWaterItems(ObservableCollection<WaterCostItem> WaterItems)
        {
            var result = new List<Row>();

            foreach (var water in WaterItems)
            {
                var oCost = water.OtherCosts == null ? 0 : water.OtherCosts;
                var totalCost = water.TotalCosts + oCost + water.TransportationCost;
                var startDate = ((DateTime)water.DurationStart);
                var DurationLength = (TimeSpan)(water.DurationFinish - water.DurationStart);
                CallculateDurtaionRows(result, totalCost, startDate, DurationLength, nameof(WaterCostItem));
            }

            return result;
        }
        private static void CallculateDurtaionRows(List<Row> result, double? totalCost, DateTime startDate, TimeSpan DurationLength, string GroupName)
        {
            var daylength = DurationLength.TotalDays;
            if (1 > daylength)
            {
                daylength = 1;
            }
            else
            {
                daylength = Math.Round(daylength) + 1;
            }

            var dailyCost = totalCost / daylength;

            for (var i = 0; i < daylength; i++)
            {
                var dateY = startDate.AddDays(i);

                var yMonth = new YearMonth
                {
                    Year = dateY.Year,
                    Month = dateY.ToString("MMM"),
                    Date = dateY,
                    Grouping = GroupName
                };

                result.Add(new Row
                {
                    YearMonth = yMonth,
                    Cost = dailyCost,
                    Revenue = 0,
                    Difference = 0
                });
            }
        }
        public async Task<PlotModel> GenerateTotalsGraphModel(
                double totalPeriodRevenue,
                double totalPeriodCost,
                double totalPeriodDifference,
                string totalCost,
                string totalIncome,
                string totalProfitOrLoss,
                string UserCurrency
            )
        {
            var model = new PlotModel { };

            #region Series 1
            var barSeries = new ColumnSeries();

            barSeries.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(totalPeriodCost),
                Color = OxyColor.Parse("#bc4749")
            });

            barSeries.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(totalPeriodRevenue),
                Color = OxyColor.Parse("#a7c957")
            });

            barSeries.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(totalPeriodDifference),
                Color = totalPeriodDifference > 0 ? OxyColor.Parse("#a7c957") : OxyColor.Parse("#bc4749")
            });

            var yAxis = new LinearAxis
            {
                StringFormat = "0", // Specify the format string without scientific notation
                Position = AxisPosition.Left, // Position the Y-axis on the left side
                Title = UserCurrency
            };

            model.Axes.Add(yAxis);

            model.Series.Add(barSeries);
            #endregion

            String[] strNames = new String[] { totalCost, totalIncome, totalProfitOrLoss };
            model.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Bottom,
                Key = "Simple Sample Data",
                ItemsSource = strNames,
                IsPanEnabled = false,
                IsZoomEnabled = false,
                Selectable = false,
                Angle = 75,
            });

            return model;
        }

        #region INotifyPropertyChanged
        // public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
