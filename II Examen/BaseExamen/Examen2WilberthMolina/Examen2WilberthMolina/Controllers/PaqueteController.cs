using AutoMapper;
using DAL.Metodos;
using Examen2WilberthMolina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Examen2WilberthMolina.Controllers
{
    public class PaqueteController : Controller
    {
        // GET: Paquete
        public ActionResult Index()
        {
            var listaPaquetes = new MPaquete().ListarPaquetes();
            var paquetes = Mapper.Map<List<Models.PaqueteModel>>(listaPaquetes);
            return View(paquetes);
        }

        // GET: Paquete/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                var paquete = new MPaquete().BuscarPaquete(id);
                var paqueteMostrar = Mapper.Map<Models.PaqueteModel>(paquete);
                return View(paqueteMostrar);
            }
            catch (Exception)
            {

                return RedirectToAction("Index");
                //throw;
            }
            
        }

        // GET: Paquete/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Paquete/Create
        [HttpPost]
        public ActionResult Create(DATOS.Paquete paquete)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                // TODO: Add insert logic here
                var paqueteInsertar = Mapper.Map<DATOS.Paquete>(paquete);
                new MPaquete().InsertarPaquete(paqueteInsertar);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
               // throw;
            }
        }

        public ActionResult Edit(int id)
        {
            try
            {
                var paquete = new MPaquete().BuscarPaquete(id);
                var paqueteMostrar = Mapper.Map<Models.PaqueteModel>(paquete);
                return View(paqueteMostrar);
            } catch(Exception e)
            {
                return RedirectToAction("Index");
                // throw;
            }

        }


        // POST: Paquete/Edit/5
        [HttpPost]

        public ActionResult Edit(Models.PaqueteModel paquete)
        {
            try
            {
                var paqueteEditar = Mapper.Map<DATOS.Paquete>(paquete);
                new MPaquete().ActualizarPaquete(paqueteEditar);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
                // throw;
            }
        }

        // GET: Paquete/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                new MPaquete().EliminarPaquete(id);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
                //throw;
            }
        }

        // POST: Paquete/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
