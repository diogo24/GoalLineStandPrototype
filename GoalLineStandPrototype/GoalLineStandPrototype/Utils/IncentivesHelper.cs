using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoalLineStandPrototype.Utils
{
    public static class IncentivesHelper
    {

        public static SelectList GetAllPlayerIncentives()
        {
            var rushingGroup = new SelectListGroup { Name = "RUSHING" };
            var rushing = new List<SelectListItem> {
                new SelectListItem { Group = rushingGroup, Value = "R_TY", Text = "Total Yards" },
                new SelectListItem { Group = rushingGroup, Value = "R_AY100", Text = "Average yards (100 attempts)" },
                new SelectListItem { Group = rushingGroup, Value = "R_TD", Text = "Touchdowns" }
            };

            var passingGroup = new SelectListGroup { Name = "PASSING" };
            var passing = new List<SelectListItem> {
                new SelectListItem { Group = passingGroup, Value = "P_R224", Text = "Passer rating (224 attempts)" },
                new SelectListItem { Group = passingGroup, Value = "P_CP224", Text = "Completion percentage (224 attempts)" },
                new SelectListItem { Group = passingGroup, Value = "P_IP224", Text = "Interception percent (224 attempts)" },
                new SelectListItem { Group = passingGroup, Value = "P_TY", Text = "Total Yards" },
                new SelectListItem { Group = passingGroup, Value = "P_YPP224", Text = "Yards per pass (224 attempts)" },
                new SelectListItem { Group = passingGroup, Value = "P_TDP", Text = "Touchdown Passes" }
            };

            var sl = new SelectList(rushing.Concat(passing), "Value", "Text");
            return sl;
        }

    }
}