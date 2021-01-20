using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Joachim_Hemsida.Models;

namespace WebApp_Joachim_Webbsite_Framework.Controllers
{
    public class PersonalSkillsLvlController : Controller
    {
        // GET: PersonalSkillsLvl
        public ActionResult Index()
        {
            return View();
        }

        // GET: PersonalSkillsLvl/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonalSkillsLvl/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonalSkillsLvl/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PersonalSkillsLvl/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonalSkillsLvl/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PersonalSkillsLvl/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
