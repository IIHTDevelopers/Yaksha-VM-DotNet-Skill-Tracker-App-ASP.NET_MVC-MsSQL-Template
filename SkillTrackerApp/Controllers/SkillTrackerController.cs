using SkillTrackerApp.DAL.Interface;
using SkillTrackerApp.DAL.Repository;
using SkillTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SkillTrackerApp.Controllers
{
    public class SkillTrackerController : Controller
    {
        private readonly ISkillTrackerInterface _Repository;
        public SkillTrackerController(ISkillTrackerInterface skill)
        {
            _Repository = skill;
        }
        public SkillTrackerController()
        {
            // Constructor logic, if needed
        }
        // GET: SkillTracker
        public ActionResult Index()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public ViewResult Details(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public ActionResult Create()
        {
            //write your code here
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult Create(Skill Skill)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public ActionResult EditAsync(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }
        [HttpPost]
        public ActionResult Edit(Skill Skill)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public ActionResult Delete(int id, bool? saveChangesError)
        {
            //write your code here
            throw new NotImplementedException();
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}