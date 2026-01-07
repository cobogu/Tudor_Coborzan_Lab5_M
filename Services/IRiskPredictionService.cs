using System.Threading.Tasks;
using System.Threading.Tasks;
using Tudor_Coborzan_Lab5_M.Models;

namespace Tudor_Coborzan_Lab5_M.Services
{
    public interface IRiskPredictionService
    {
        Task<string> PredictRiskAsync(RiskInput input);
    }
}
