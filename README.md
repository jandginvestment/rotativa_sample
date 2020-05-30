# Steps

## Add Rotativa 1.2.0 beta using Nuget Package Manager
## Add below line in startup.cs file in configure method
 ``` RotativaConfiguration.Setup(env.WebRootPath); ```
## Copy wkhtml.exe files to wwroot/Rotativa folder


## Modify the controller method as
 ```
 /// <summary>
        /// Method to return PDF to the view
        /// </summary>
        /// <returns>PDF file</returns>
        public IActionResult Index()
        {
            return new Rotativa.AspNetCore.ViewAsPdf("Index", GetStudents());  // Index view name , GetStudents() data as Model
            //return View();
        }
 ```       
