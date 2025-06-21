namespace QA_API.Entities
{
    public class Coaching
    {
        public decimal IdCoaching { get; set; }
        public decimal IdUser { get; set; }
        public decimal IdAccount { get; set; }
        public decimal IdRubric { get; set; }
        public DateTime DateCoaching { get; set; }
        public decimal Evaluator { get; set; }
        public bool LState { get; set; }
        
    }

    public class CoachingAnswer
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public Coaching? Datum { get; set; }
        public List<Coaching>? Data { get; set; }
    }
}
