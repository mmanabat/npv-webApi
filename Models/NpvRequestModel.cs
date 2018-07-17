using System.Collections.Generic;

namespace npvWebAPI.Models
{
    public class NpvRequest
    {
        public double InitialInvestment { get; set; }
        public double DiscountRateIncrement { get; set; }
        public double UpperBound { get; set; }
        public double LowerBound { get; set; }
        public IList<double> CashFlows { get; set; }
        public bool IsChecked { get; set; }
    }
}