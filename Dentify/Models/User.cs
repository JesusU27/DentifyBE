namespace Dentify.Models;

public class User
{
    public int id { get; set; }
    public string username { get; set; }
    public string first_name { get; set; }
    public string last_name { get; set; }
    public string email { get; set; }
    public string phone { get; set; }
    public DateTime register_date { get; set; }
    public string company { get; set; }
    public string password { get; set; }
}