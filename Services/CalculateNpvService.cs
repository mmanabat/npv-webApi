using System;
using System.Collections.Generic;
using npvWebAPI.Models;

namespace npvWebAPI.Services
{
    public class NpvService : ICalculate
    {
        public NpvResponse GetChartData(NpvRequest request)
        {
            IList<double> npvList = new List<double>();
            IList<string> npvLabelList = new List<string>();
            if (request.IsChecked)
            {
                var i = request.LowerBound;
                do
                {
                    var val = this.CalculateNPV(Math.Round(i, 2), request.InitialInvestment, request.CashFlows);
                    npvList.Add(val);
                    npvLabelList.Add("NPV for " + i);
                    i += request.DiscountRateIncrement;
                } while (Math.Round(i, 2) <= request.UpperBound);
            }
            
            var result = this.BuildNpvResponse(npvLabelList, npvList);
            return result;
        }

        public double GetNpv(NpvChartRequest request)
        {
            return this.CalculateNPV(request.DiscountRateIncrement, request.InitialInvestment, request.CashFlows);
        }

        private double CalculateNPV(double rate, double initialInvestment, IList<double> cashflows)
        {
            double value = 0;
            var index = 0;
            foreach (var item in cashflows)
            {
                value += item / Math.Pow(1 + ((rate / 100)), index++ + 1);
            }

            value = Math.Round(value - initialInvestment, 2);

            return value;
        }

        private NpvResponse BuildNpvResponse(IList<string> npvLabelList,  IList<double> npvList)
        {
            return new NpvResponse
            {
                Labels = npvLabelList,
                Data = npvList
            };
        }
    }
}