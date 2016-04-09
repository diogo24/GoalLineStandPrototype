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

    public class Team
    {
        public string Name { get; set; }
    }

    public class PlayerContractDetails
    {
        public PlayerContractDetails()
        {
            Player = new Player();
            Team   = new Team();
        }

        public Player Player { get; set; }
        public Team Team { get; set; }

        public int Seasons { get { return TerminateYear - BeginYear; } }

        public int BeginYear { get; set; }
        public int TerminateYear { get; set; }

        public List<SalarySeason> SalarySeason { get; set; }

        /* 
         * In addition, Club will pay Player such earned performance bonuses as may be called for
            in this contract; Player’s necessary traveling expenses from his residence to training
            camp; Player’s reasonable board and lodging expenses during preseason training and in
            connection with playing preseason, regular season, and postseason football games outside
            Club’s home city; Player’s necessary traveling expenses to and from preseason,
            regular season, and postseason football games outside Club’s home city; Player’s necessary
            traveling expenses to his residence if this contract is terminated by Club; and such
            additional compensation, benefits and reimbursement of expenses as may be called for in
            any collective bargaining agreement in existence during the term of this contract. (For
            purposes of this contract, a collective bargaining agreement will be deemed to be “in
            existence” during its stated term or during any period for which the parties to that
            agreement agree to extend it.) 
         */

        public int SigningBonus { get; set; }

        public List<PlayerIncentives> PlayerIncentives { get; set; }
    }

    public class SalarySeason
    {
        public int Salary { get; set; }
        public int Year { get; set; }
    }

    public class PlayerIncentives
    {
        public string Code { get; set; }
        public int Milestone { get; set; }
        public int Bonus { get; set; }
    }
}