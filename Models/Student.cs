using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentPortal.Models
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }
       
        [Required(ErrorMessage = "Please Enter Student First Name")]
        public string? FirstName { get; set; }


       
        [Required(ErrorMessage = "Please Enter Student Last Name")]
        public string? LastName { get; set; }




        [Required(ErrorMessage = "Please Enter Student DOB")]
        public DateTime StudentDOB { get; set; }



        [Required(ErrorMessage = "Please Enter Student Gender")]
        public string? Gender { get; set; }



        [Required(ErrorMessage = "Please Enter Student Standard")]
        public int Standard { get; set; }



        [Required(ErrorMessage = "Please Enter Student Previous Year Percentage")]
        public float PreviousYearPercentage { get; set; }



        [Required(ErrorMessage = "Please Select Relationship with Student")]
        public string? RelationWithStudent { get; set; }



        // contains all details of file
        [NotMapped]
        public IFormFile? ProfileImage { get; set; }

      

        public string? ProfileImagePath { get; set; }

      

        public int ParentId { get; set; }

        public virtual Parent? Parent { get; set; }

        public virtual List<Sport>? Sports { get; set; }

    }
}
