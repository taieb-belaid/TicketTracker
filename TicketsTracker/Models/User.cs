#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
namespace TicketsTracker.Models;

public class User
{
    [Key]
    public int UserId { get; set; } 
    [Required]
    [MinLength(2,ErrorMessage="First name must be 2 characters or longer!")]
    public string FirstName { get; set; }
    [Required]
    [MinLength(2,ErrorMessage="First name must be 2 characters or longer!")]

    public string LastName { get; set; } 
    [EmailAddress(ErrorMessage ="Invalid Email Address")]
    [Required]
    public string Email { get; set; }
    [DataType(DataType.Password)]
    [Required]
    [MinLength(8, ErrorMessage="Password must be 8 characters or longer!")]
    public string Password { get; set; } 
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    // Will not be mapped to your users table!
    [NotMapped]
    [Compare("Password")]
    [DataType(DataType.Password)]
    public string Confirm { get; set; } 

}