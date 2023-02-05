using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProyectoMVC.Models;

namespace ProyectoMVC.Controllers
{
    public class AlumnoController : Controller
    {
        private EscuelaContext _context;
        public IActionResult Inicio()
        {
        //    var Alumno=new Alumno();
        //     Alumno.Nombre="Pepe Perez";
        //     Alumno.Id= Guid.NewGuid().ToString();
           
        //     return View(Alumno);
            var escuela=_context.Alumnos.FirstOrDefault();
           return View(escuela);

        }

         public IActionResult MultiAlumno()
        {
            // var listaAlumnos = new List<Alumno>(){
            //                 new Alumno{Nombre="Juan Ramirez",
            //                     Id= Guid.NewGuid().ToString()
            //                 } ,
            //                 new Alumno{Nombre="Ana Lopez",
            //                     Id= Guid.NewGuid().ToString()
            //                 },
            //                 new Alumno{Nombre="Juanito Sanchez",
            //                     Id= Guid.NewGuid().ToString()
            //                 },
            //                 new Alumno{Nombre="Pedro Cascante",
            //                    Id= Guid.NewGuid().ToString()
            //                 }
            //                 ,
            //                 new Alumno{Nombre="Kevin Perez",
            //                     Id= Guid.NewGuid().ToString()
            //                 }
            //     };

            // return View("MultiAlumno", listaAlumnos);

            var escuela=_context.Alumnos.ToList();
           return View(escuela);
        }

        public AlumnoController (EscuelaContext context){
            _context = context;
        }

        
    }
    
}
