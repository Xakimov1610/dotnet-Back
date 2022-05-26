namespace StudentApi.Models;
public class NewStudent
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public Guid TeacherId { get; set; }
}