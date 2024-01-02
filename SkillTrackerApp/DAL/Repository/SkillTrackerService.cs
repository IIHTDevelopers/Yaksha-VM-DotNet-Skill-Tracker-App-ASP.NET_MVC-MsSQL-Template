using SkillTrackerApp.DAL.Interface;
using SkillTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SkillTrackerApp.DAL.Repository
{
    public class SkillTrackerSkill : ISkillTrackerInterface
    {
        private ISkillTrackerRepository _repo;
        public SkillTrackerSkill(ISkillTrackerRepository repo)
        {
            this._repo = repo;
        }

        public int DeleteSkill(int SkillId)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Skill GetSkillByID(int SkillId)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public void Save()
        {
            //write your code here
            throw new NotImplementedException();
        }


        IEnumerable<Skill> ISkillTrackerInterface.GetSkills()
        {
            //write your code here
            throw new NotImplementedException();
        }

        Skill ISkillTrackerInterface.InsertSkill(Skill Skill)
        {
            //write your code here
            throw new NotImplementedException();
        }

        bool ISkillTrackerInterface.UpdateSkill(Skill Skill)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}