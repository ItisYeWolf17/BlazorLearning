namespace QA_API.Entities
{
    public class Rubric
    {
        public decimal IdRubric { get; set; }
        public string? NameRubric { get; set; }
        public bool LState { get; set; }
    }

    public class RubricAnswer //Response Object Class
    {
        public RubricAnswer()
        {
            Code = "00";
            Message = "";
        }

        public string Code { get; set; }
        public string Message { get; set; }
        public Rubric? Datum { get; set; }
        public List<Rubric>? Data { get; set; }
    }
}
