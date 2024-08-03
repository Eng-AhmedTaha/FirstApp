using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using FirstApp.CustomValidation;
namespace FirstApp.Models
{
    public class EmployeeModel
    {
        [Key]
        [ValidateNever]
        public int Id { get; set; }
        [Required(ErrorMessage ="please enter employee name")]
        [StringLength(100,ErrorMessage ="name must be less than 100")]
        public string Name { get; set; } = "";
        [Required(ErrorMessage ="please enter title")]
        [StringLength(80, ErrorMessage = "title must be less than 80")]
        public string Title { get; set; } = "";
        //[Required(ErrorMessage ="please enter email")]
        [EmailAddress(ErrorMessage = "please enter valid email")]
        [Remote(action: "VerifyEmail", controller: "Employees", ErrorMessage = "email found")]
        [StringLength(100, ErrorMessage = "email must be less than 100")]
        [ValidateEmail("gmail",ErrorMessage ="you must use gmail")]
        public string Email { get; set; } =null;
        public string Description { get; set; } = "";
        public string ImageName { get; set; } = "";
    }
}
