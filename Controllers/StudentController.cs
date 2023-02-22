using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Nest;
using StudentPortal.Models;
using StudentPortal.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using System.Web;

namespace StudentPortal.Controllers
{
    public class StudentController : Controller
    {

        private StudentDbContext _db;

        private readonly IWebHostEnvironment _webHostEnvironment;

     

        public StudentController(StudentDbContext db, IWebHostEnvironment webHostEnvironment)
        {
            _db=db;
            _webHostEnvironment = webHostEnvironment;
        }

       


        public IActionResult Index()
        {
            
            Student student = new Student();   
            Parent parent=new Parent(); 
            Sport sport=new Sport();

         


            StudentDetails studentDetails = new StudentDetails() {

                Student = student,

                Parent = parent,

                Sport = sport

            };


            var data = _db.Students;


            ViewBag.datalist = data;
          

            return View(studentDetails);
        }


        [HttpPost]
        public IActionResult Add(StudentDetails obj)
        {

         
            //Sport sport = obj.Sport;

            Parent parent=obj.Parent;
         
            Student student=obj.Student;

           var ifile = obj.Student.ProfileImage;

       //   IFormFile ifile = Request.Form.Files["stdimage"];

           

            _db.Parents.Add(parent);
            _db.SaveChanges();


            var p = _db.Parents;
            var latestEntry = p.OrderByDescending(f => f.ParentId).FirstOrDefault();
            int pid = latestEntry.ParentId;

            student.ParentId = pid;



            if (ifile != null && ifile.Length > 0)
            {


                string folder ="images/";
                folder+= Guid.NewGuid().ToString()+"_"+ifile.FileName;

                obj.Student.ProfileImagePath = folder;

                string serverFolder = Path.Combine(_webHostEnvironment.WebRootPath,folder);


                ifile.CopyTo(new FileStream(serverFolder, FileMode.Create));




              //  var fileName = Path.GetFileName(ifile.FileName);
               // var filePath = Path.Combine(_webHostEnvironment.WebRootPath, "images", fileName);
               // string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images");
              //  string fileNameWithPath = Path.Combine(path, ifile.FileName);
                // string uploadpath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", fileName);

                //using (var stream = new FileStream(fileNameWithPath, FileMode.Create))
                //{
                //    ifile.CopyTo(stream);
                //}

             
                //student.ProfileImage = $"/images/{fileName}";

           
               


                //_db.Update(student);
                //_db.SaveChanges();


            }


            _db.Students.Add(student);
            _db.SaveChanges();



         //   string sprtid = Request.Form["id"];


         





            //List<int> st = sprtid.Split(',').Select(int.Parse).ToList();


            //List<Sport> slist = new List<Sport>();



            //foreach (int i in st)
            //{
            //  Sport sp= _db.Sports.Find(i);
            //    slist.Add(sp);
            //}


            //student.Sports = slist; 
          

            //_db.Update(student);    
            //_db.SaveChanges();



           // _db.Sports.Add(sport);
          
            return View("Index");
                
        }

      
    }

}
