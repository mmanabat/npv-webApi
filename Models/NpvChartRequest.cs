using System.Collections.Generic;

namespace npvWebAPI.Models
{
    public class NpvChartRequest
    {
        public double InitialInvestment { get; set; }
        public double DiscountRateIncrement { get; set; }
        public IList<double> CashFlows { get; set; }
    }
}