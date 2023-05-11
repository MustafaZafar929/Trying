using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Account
{
    [Key]
    public int AccountId { get; set; }

    [Required]
    [StringLength(50)]
    public string Username { get; set; }

    [Required]
    [StringLength(50)]
    public string Password { get; set; }

    // Constructor
    public Account()
    {
    }

    // Constructor with parameters
    public Account(string username, string password)
    {
        this.Username = username;
        this.Password = password;
    }
}
