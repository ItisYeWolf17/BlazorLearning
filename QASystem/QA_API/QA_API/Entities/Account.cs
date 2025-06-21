namespace QA_API.Entities
{
    public class Account
    {
        public decimal IdAccount { get; set; }
        public string? NameAccount { get; set; }
        public bool LState { get; set; }
    }

    public class AccountAnswer
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public Account? Datum { get; set; }
        public List<Account>? Data { get; set; }
    }
}
