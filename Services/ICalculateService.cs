using npvWebAPI.Models;

namespace npvWebAPI.Services
{
    public interface ICalculate
    {
        NpvResponse GetChartData(NpvRequest request);
        double GetNpv(NpvChartRequest request);
    }
}