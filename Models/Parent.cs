using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentPortal.Models
{
    public class Parent
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ParentId { get; set; }



        [Required(ErrorMessage = "Please Enter Parent First Name")]
        public string? PFirstName { get; set; }




        [Required(ErrorMessage = "Please Enter Parent Last Name")]
        public string? PLastName { get; set; }




        [Required(ErrorMessage = "Please Enter Parent DOB")]
        public DateTime ParentDOB { get; set; }




        [Required(ErrorMessage = "Please Enter Parent Occupation")]
        public string? Occupation { get; set; }



        public virtual List<Student>? Students { get; set; }


    }
}
