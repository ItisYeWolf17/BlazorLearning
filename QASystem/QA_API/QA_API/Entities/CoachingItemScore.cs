namespace QA_API.Entities
{
    public class CoachingItemScore
    {
        public decimal IdCoachingItem { get; set; }
        public decimal IdCoaching { get; set; }
        public decimal IdItem { get; set; }
        public decimal Score { get; set; }
        public string? Comments { get; set; }
        public bool LState { get; set; }
    }

    public class CoachingItemScoreAnswer
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public CoachingItemScore? Datum { get; set; }
        public List<CoachingItemScore>? Data { get; set; }
    }
}
