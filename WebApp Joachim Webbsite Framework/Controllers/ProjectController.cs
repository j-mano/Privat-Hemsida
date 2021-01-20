using System;
using System.Collections.Generic;
using System.Web.Mvc;
using ApiClass.Apis;
using Backend_Processing.Bussniess_logic.Projects;
using Backend_Processing.Interfaces;
using Joachim_Hemsida.Models;

namespace WebApp_Joachim_Webbsite_Framework.Controllers
{
    public class ProjectController : Controller, IGetProject
    {
        // GET: Project
        public ActionResult Index()
        {
            List<FrontendProjectListModel> projectsFrontend = new List<FrontendProjectListModel>();

            try
            {
                List<ApiClass.ApiProjectApiModel> projects = Load_Projects.GetProjectsAsync();

                ViewBag.NumbOfProjects = LvlApiClass.Apis.GetNumbOfProjects.GetNumbofProjectsAsync();

                foreach (var project in projects)
                {
                    projectsFrontend.Add(new FrontendProjectListModel
                    {
                        idInDatabase                    = project.idInDatabase,
                        initalDate                      = project.initalDate,
                        projectName                     = project.projectName,
                        lastUpdatedDate                 = project.lastUpdatedDate,
                        projectDescription              = project.projectDescription,
                        programingLangugeWritenwidth    = project.programingLangugeWritenwidth
                    });
                }

                return View(projectsFrontend);
            }
            catch
            {
                return View(projectsFrontend);
            }
        }

        // GET: Project/Details
        public ActionResult Details(int id)
        {
            FrontendProjectListModel project = new FrontendProjectListModel();

            try
            {
                //ApiClass.ApiProjectApiModel loadedproject = IGetProject.ReferenceEquals;

                ApiClass.ApiProjectApiModel loadedproject = ApiClass.Apis.LoadSpecificProject.LoadSelectedProject(id);

                loadedproject = LoadSpecificProject.LoadSelectedProject(id);

                project.idInDatabase                    = loadedproject.idInDatabase;
                project.initalDate                      = loadedproject.initalDate;
                project.lastUpdatedDate                 = loadedproject.lastUpdatedDate;
                project.projectDescription              = loadedproject.projectDescription;
                project.programingLangugeWritenwidth    = loadedproject.programingLangugeWritenwidth;

                return View(project);
            }
            catch
            {
                return View(project);
            }
        }

        // GET: Project/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Project/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FrontendProjectListModel inputvalues)
        {
            try
            {
                CreateProject.createProject(inputvalues.projectName, inputvalues.initalDate, inputvalues.lastUpdatedDate, inputvalues.projectDescription, inputvalues.programingLangugeWritenwidth);
                return RedirectToAction("Index");
            }
            catch(Exception e)
            {
                @ViewBag.ErrorMessage = "Fel försök igen. Mer utförligt fel: " + e;
                return View();
            }
        }

        // GET: Project/Edit/5
        public ActionResult Edit(FrontendProjectListModel SelectedProject)
        {
            return View(SelectedProject);
        }

        // POST: Project/Edit/5
        [HttpPost]
        public ActionResult Edit(FrontendProjectListModel SelectedProject, FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View(SelectedProject);
            }
        }

        // GET: Project/Delete/5
        public ActionResult Delete(FrontendProjectListModel SelectedProjec)
        {
            return View(SelectedProjec);
        }

        // POST: Project/Delete/5
        [HttpPost]
        public ActionResult Delete(FrontendProjectListModel SelectedProjec, FormCollection collection)
        {
            try
            {
                LvlApiClass.Apis.Projects.DeleteProjects.deleteProject(SelectedProjec.idInDatabase);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public LoadProject LoadProject(int id)
        {
            List<Backend_Processing.BackendProjectListProcessModel> backendmodel = new List<Backend_Processing.BackendProjectListProcessModel>();

            

            throw new NotImplementedException();
        }
    }
}
