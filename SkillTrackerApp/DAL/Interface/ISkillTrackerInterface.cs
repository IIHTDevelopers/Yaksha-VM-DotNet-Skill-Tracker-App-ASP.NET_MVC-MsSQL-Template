﻿using SkillTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTrackerApp.DAL.Interface
{
    public interface ISkillTrackerInterface 
    {
        IEnumerable<Skill> GetSkills();
        Skill GetSkillByID(int SkillId);
        Skill InsertSkill(Skill Skill);
        int DeleteSkill(int SkillId);
        bool UpdateSkill(Skill Skill);
        void Save();
    }
}