using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Proyecto_prog_3_mvc.Models;
using Proyecto_prog_3_mvc.Models.view_models;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_prog_3_mvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()  
        {
            List<tabla_view_model> lsta;
            using ( proyectoProg3Entities db = new proyectoProg3Entities() )
            {
                 lsta = (from d in db.trabajos  // lista que trae los datos de la base de datos 
                            select new tabla_view_model
                            {
                                Id = d.trabajo_id,
                                ubicacion = d.ubicacion,
                                posicion = d.posicion,
                                compañia = d.compañia
                            }).ToList();         
                
                  return View(lsta);
            }           
        }

        public ActionResult Nuevo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Nuevo(TablaViewModel model )  /// ojo para validacion y insercion de datos 
        {
            try
            {
                if(ModelState.IsValid)
                {
                    using(proyectoProg3Entities db = new proyectoProg3Entities())
                    {
                        var oTabla = new trabajos();
                        oTabla.ubicacion = model.ubicacion;
                        oTabla.posicion = model.posicion;
                        oTabla.compañia = model.compañia;
                        db.trabajos.Add(oTabla);
                        db.SaveChanges();
                    }
                    return RedirectToAction("Nuevo");
                }

                return View("Index");              
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public ActionResult Seleccion (string Busqueda)
        {
            List<ListBuscador> lsta_seleccion; // lista

            using (proyectoProg3Entities db = new proyectoProg3Entities())
            {                              
                // validaciones                 
                
                    lsta_seleccion = (from d in db.trabajos where d.posicion == Busqueda.Trim() || d.compañia == Busqueda.Trim()  // lista que trae los datos de la base de datos 
                            select new ListBuscador
                            {
                                Id = d.trabajo_id,
                                ubicacion = d.ubicacion,
                                posicion = d.posicion,
                                compañia = d.compañia
                            }).ToList();
                    
                    return View(lsta_seleccion);                                    
               
            }
               
        }
            
    }
}