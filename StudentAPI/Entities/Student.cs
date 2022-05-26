namespace StudentApi.Entities;
public class Student
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }    
    public string LastName { get; set; }    
    public int Age { get; set; }
    public Guid TeacherId { get; set; }    
}