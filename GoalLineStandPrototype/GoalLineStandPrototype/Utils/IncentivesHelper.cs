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
                new SelectListItem { Group = rushingGroup, Value = "RU_TY", Text = "Total Yards" },
                new SelectListItem { Group = rushingGroup, Value = "RU_AY100", Text = "Average yards (100 attempts)" },
                new SelectListItem { Group = rushingGroup, Value = "RU_TD", Text = "Touchdowns" }
            };

            var passingGroup = new SelectListGroup { Name = "PASSING" };
            var passing = new List<SelectListItem> {
                new SelectListItem { Group = passingGroup, Value = "PA_R224", Text = "Passer rating (224 attempts)" },
                new SelectListItem { Group = passingGroup, Value = "PA_CP224", Text = "Completion percentage (224 attempts)" },
                new SelectListItem { Group = passingGroup, Value = "PA_IP224", Text = "Interception percent (224 attempts)" },
                new SelectListItem { Group = passingGroup, Value = "PA_TY", Text = "Total Yards" },
                new SelectListItem { Group = passingGroup, Value = "PA_YPP224", Text = "Yards per pass (224 attempts)" },
                new SelectListItem { Group = passingGroup, Value = "PA_TDP", Text = "Touchdown Passes" }
            };

            var receivingGroup = new SelectListGroup { Name = "RECEIVING" };
            var receiving = new List<SelectListItem> {
                new SelectListItem { Group = receivingGroup, Value = "RE_TR", Text = "Total receptions" },
                new SelectListItem { Group = receivingGroup, Value = "RE_TY", Text = "Total Yards" },
                new SelectListItem { Group = receivingGroup, Value = "RE_AY100", Text = "Average yards (32 receptions)" },
                new SelectListItem { Group = receivingGroup, Value = "RE_TD", Text = "Touchdowns" }
            };

            var defenseGroup = new SelectListGroup { Name = "DEFENSE" };
            var defense = new List<SelectListItem> {
                new SelectListItem { Group = defenseGroup, Value = "DE_I", Text = " Interceptions" },
                new SelectListItem { Group = defenseGroup, Value = "DE_IRY", Text = " Interception return yards" },
                new SelectListItem { Group = defenseGroup, Value = "DE_IRTD", Text = "Touchdowns on interception returns" },
                new SelectListItem { Group = defenseGroup, Value = "DE_OFR", Text = "Opponent fumble recoveries" },
                new SelectListItem { Group = defenseGroup, Value = "DE_OFRY", Text = "Opponent fumble return yards" },
                new SelectListItem { Group = defenseGroup, Value = "DE_OFTD", Text = "Touchdowns on opponent fumble returns" },
                new SelectListItem { Group = defenseGroup, Value = "DE_S", Text = " Sacks" }
            };

            var sl = new SelectList(rushing.Concat(passing).Concat(receiving).Concat(defense), "Value", "Text", "Group.Name", new { });
            return sl;
        }

        public static SelectList GetAllTeamIncentives()
        {
            var offenseGroup = new SelectListGroup { Name = "OFFENSE" };
            var offense = new List<SelectListItem> {
                new SelectListItem { Group = offenseGroup, Value = "O_PS", Text = "Points scored by Team" },
                new SelectListItem { Group = offenseGroup, Value = "O_TDS", Text = "TD’s scored by Team" },
                new SelectListItem { Group = offenseGroup, Value = "O_TO", Text = "Total Offense (net yards)" },
                new SelectListItem { Group = offenseGroup, Value = "O_ANYSR", Text = "Avg net yds gained per rush" },
                new SelectListItem { Group = offenseGroup, Value = "O_ANYSP", Text = "Avg net yds gained per pass" },
                new SelectListItem { Group = offenseGroup, Value = "O_SA", Text = "Sacks allowed" },
                new SelectListItem { Group = offenseGroup, Value = "O_PPC", Text = "Passing % completed" },
            };

            var defenseGroup = new SelectListGroup { Name = "DEFENSE"  };
            var defense = new List<SelectListItem> {
                new SelectListItem { Group = defenseGroup, Value = "D_PA", Text = "Points allowed by Team" },
                new SelectListItem { Group = defenseGroup, Value = "D_TDA", Text = "TD’s allowed by Team" },
                new SelectListItem { Group = defenseGroup, Value = "D_TD", Text = "Total Defense (net yards)" },
                new SelectListItem { Group = defenseGroup, Value = "D_ANYAR", Text = "Avg net yds allowed per rush" },
                new SelectListItem { Group = defenseGroup, Value = "D_ANYAP", Text = "Avg net yds allowed per pass" },
                new SelectListItem { Group = defenseGroup, Value = "D_S", Text = "Sacks" },
                new SelectListItem { Group = defenseGroup, Value = "D_I", Text = "Interceptions" },
            };

            var specialTeamsGroup = new SelectListGroup { Name = "SPECIAL TEAMS" };
            var specialTeams = new List<SelectListItem> {
                new SelectListItem { Group = specialTeamsGroup, Value = "ST_OPRA", Text = "Own punt return avg" },
                new SelectListItem { Group = specialTeamsGroup, Value = "ST_OKRA", Text = "Own kickoff return avg" },
                new SelectListItem { Group = specialTeamsGroup, Value = "ST_OPRA", Text = "Opponent punt return avg" },
                new SelectListItem { Group = specialTeamsGroup, Value = "ST_OKRA", Text = "Opponent kickoff return avg" }
            };

            var sl = new SelectList(offense.Concat(defense).Concat(specialTeams), "Value", "Text", "Group.Name", new { });
            return sl;
        }
    }
}