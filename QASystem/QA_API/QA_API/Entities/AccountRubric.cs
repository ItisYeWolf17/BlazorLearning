namespace QA_API.Entities
{
    public class AccountRubric
    {
        public decimal IdRubric { get; set; }
        public decimal IdAccount { get; set; }
        public bool State { get; set; }

    }

    public class AccountRubricAnswer
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public AccountRubric? Datum { get; set; }
        public List<AccountRubric>? Data { get; set; }
    }
}
