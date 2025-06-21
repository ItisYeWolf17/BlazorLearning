namespace QA_API.Entities
{
    public class Role
    {
        public decimal IdRole { get; set; }
        public string? NameRole { get; set; }
        public bool LState { get; set; }
    }

    public class RoleAnswer //Response Object Class
    {
        public RoleAnswer()
        {
            Code = "00";
            Message = "";
        }

        public string Code { get; set; }
        public string Message { get; set; }
        public RoleAnswer? Datum { get; set; }
        public List<RoleAnswer>? Data { get; set; }
    }
}
