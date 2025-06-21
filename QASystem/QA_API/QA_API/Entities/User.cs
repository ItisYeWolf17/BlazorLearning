namespace QA_API.Entities
{
    public class User
    {
        public decimal IdUser { get; set; }
        public string? NameUser { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Passwd { get; set; }
        public string? TempPasswd { get; set; }
        public string? Phone { get; set; }
        public decimal IdRole { get; set; }
        public bool? LState { get; set; }
    }

    public class UserAnswer //Response Class for requests
    {
        public UserAnswer()
        {
            Code = "00";
            Message = string.Empty;
        }

        public string? Code { get; set; }
        public string? Message { get; set; }
        public User? Datum { get; set; }
        public List<User>? Data { get; set; }
    }
}
