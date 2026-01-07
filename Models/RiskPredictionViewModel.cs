namespace Tudor_Coborzan_Lab5_M.Models
{
    public class RiskPredictionViewModel
    {

        public string InspectionType { get; set; }
        public string ViolationDescription { get; set; }
        // rezultat întors de API
        public string PredictedRisk { get; set; }
    }
}
