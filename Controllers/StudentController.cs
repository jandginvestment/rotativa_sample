using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using rotativa_sample.Models;

namespace rotativa_sample.Controllers
{
    public class StudentController : Controller
    {
        /// <summary>
        /// Method to return PDF to the view
        /// </summary>
        /// <returns>PDF file</returns>
        public IActionResult Index()
        {
            return new Rotativa.AspNetCore.ViewAsPdf("Index", GetStudents());  // Index view name
            //return View();
        }
       
        public List<Student> GetStudents ()
        {
            var students= new List<Student> { 
            new Student{ID=1, Class="12",Name="ஸ்ரீதர் ",Section="அ"}      ,
             new Student{ID=5, Class="12",Name="இராமசாமி ",Section="அ"}      ,
             new Student{ID=8, Class="12",Name="இந்திரன் ",Section="ஆ"}      ,
             new Student{ID=10, Class="12",Name="குப்புசாமி",Section="ஆ"}      ,
             new Student{ID=12, Class="12",Name="இரமேஷ்",Section="அ"}      ,
             new Student{ID=16, Class="12",Name="வேலன்",Section="அ"}      ,

            };
            return students.OrderByDescending(x => x.Section).ThenBy(x => x.Name).ToList();
        }
    }
}