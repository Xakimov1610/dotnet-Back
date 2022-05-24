using System.Globalization;
namespace webapi.Model;

public class Generate
{
    public int Lengs { get; set; }
    
    public bool HasUpper { get; set; } = true;

    public bool HasLower { get; set; } = true;
    
    public bool HasNumber { get; set; } = true;
    
    public bool HasCharakter { get; set; } = true;

}