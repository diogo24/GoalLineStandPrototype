using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoalLineStandPrototype.Models
{
    //public class PlayerContractModels
    //{

    //}

    public class Player
    {
        //public string FirstName { get; set; }
        //public string LastName { get; set; }

        public string PlayerName { get; set; }

        public string Position { get; set; }
        //public DateTime DateOfBirth { get; set; }
        //public int Age {
        //    get
        //    {
        //            return CalculateAgeCorrect(DateOfBirth, DateTime.Now);
        //    }
        //}


        //public int DraftYear { get; set; }
        //public int DraftRound { get; set; }
        //public int DraftOverall { get; set; }

        //public String College { get; set; }

        //public String Agent { get; set; }

        public PlayerContract CurrentContract { get; set; }
        public string Team { get; set; }

        //public IEnumerable<PlayerContract> Contracts { get; set; }

        //public int CalculateAgeCorrect(DateTime birthDate, DateTime now)
        //{
        //    int age = now.Year - birthDate.Year;

        //    if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
        //        age--;

        //    return age;
        //}
    }

    public class PlayerContract
    {
        //public DateTime StartDate { get; set; }
        //public DateTime EndDate { get; set; }

        public double TotalValue { get; set; }
        public double SigningBonus { get; set; }
        public double Guaranteed { get; set; }
        public decimal GuaranteedPct { get; set; }

        public bool Expires { get; set; }
    }
}