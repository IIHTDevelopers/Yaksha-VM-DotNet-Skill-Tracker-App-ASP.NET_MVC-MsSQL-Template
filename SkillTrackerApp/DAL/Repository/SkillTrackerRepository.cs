using SkillTrackerApp.DAL.Interface;
using SkillTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SkillTrackerApp.DAL.Repository
{
    public class SkillTrackerRepository : ISkillTrackerRepository
    {
        private SkillTrackerDbContext _context;
        public SkillTrackerRepository(SkillTrackerDbContext Context)
        {
            this._context = Context;
        }
        public IEnumerable<Skill> GetSkills()
        {
            //write your code here
            throw new NotImplementedException();
        }
        public Skill GetSkillByID(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public Skill InsertSkill(Skill Skill)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public int DeleteSkill(int SkillID)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public bool UpdateSkill(Skill Skill)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public void Save()
        {
            //write your code here
            throw new NotImplementedException();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
