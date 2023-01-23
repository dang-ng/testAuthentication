using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication6.Models;

[BindProperties]
public class CustomerInfo
{
    [Display(Name = "Your Name")] 
    [StringLength(10,MinimumLength = 3,ErrorMessage = "sai dinh dang")]
    public string Name { get; set; }
    [DisplayName("Your Email")] 
    [EmailAddress(ErrorMessage = "sai dinh dang")]
    public string Email { get; set; }
    [Display(Name="Your Birthyear")] 
    [Range(minimum:1900,maximum:3000)]
    public int? YearOfBirth { get; set; }
}