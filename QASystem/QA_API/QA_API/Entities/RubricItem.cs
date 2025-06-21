namespace QA_API.Entities
{
    public class RubricItem
    {
        public decimal IdItem { get; set; }
        public decimal IdRubric { get; set; }
        public string? ItemName { get; set; }
        public string? ItemDesc { get; set; }
        public decimal MaxScore { get; set; }
        public int OrderItem { get; set; }
        public bool LState { get; set; }
    }

    public class RubricItemAnswer
    {
        public RubricItemAnswer()
        {
            Code = "00";
            Message = "";
        }

        public string Code { get; set; }
        public string Message { get; set; }
        public RubricItem? Datum { get; set; }
        public List<RubricItem>? Data { get; set; }
    }
}
