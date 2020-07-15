namespace AdmitereOnline.API.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        public const string Admin = "Admin";
        public const string User = "User";
        public int UserID { get; set; }
    }
}