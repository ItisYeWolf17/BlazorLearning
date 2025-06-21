namespace QA_API.Entities
{
    public class UserAccount
    {
        public decimal IdAccount { get; set; }  
        public decimal IdUser { get; set; }
    }

    public class UserAccountAnswer
    {
        public UserAccountAnswer()
        {
            Code = "00";
            Message = "";
        }

        public string Code { get; set; }
        public string Message { get; set; }
        public UserAccount? Datum { get; set; }
        public List<UserAccount>? Data { get; set; }
    }
}
