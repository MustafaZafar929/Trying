//using Microsoft.EntityFrameworkCore;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

public class BioData
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Sex { get; set; }
    public int Height { get; set; }
    public string? City { get; set; }
}

//public class BioData
//{
//    public int Id { get; set; }
//    public string? Name { get; set; }
//    public DateTime DateOfBirth { get; set; }
//    public string Sex { get; set; }
//    public int Height { get; set; }
//    public string? City { get; set; }

//    public string UserId { get; set; } // Foreign key for user's account
//    public Account User { get; set; } // Navigation property to the user's account
//    public int AccountId { get; internal set; }
//}
