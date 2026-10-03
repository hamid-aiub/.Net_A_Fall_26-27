namespace IntroToMVC_A.Models
{
    public class UserModel
    {
        public int? id { get; set; }
        public string?  username { get; set; }
        public required string  email { get; set; }
        public required string password { get; set; }
    }
}
