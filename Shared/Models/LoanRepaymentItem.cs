using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    public class LoanRepaymentItem : BaseItem
    {
        public DateTime Date { get; set; }
        public double TotalAmountRepaid { get; set; }
        public string? LoanProvider { get; set; }
        public string? OtherLoanProvider { get; set; }
        public double OtherCosts { get; set; }
        public string? Comment { get; set; }
    }
}
