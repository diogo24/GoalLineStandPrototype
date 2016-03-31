using GoalLineStandPrototype.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;

namespace GoalLineStandPrototype.Controllers
{
    public class PlayerContractController : Controller
    {
        private string NFLPlayersContractsFilePath = HostingEnvironment.MapPath("~/App_Data/nfl players contracts.csv");

        //http://stackoverflow.com/questions/3776458/split-a-comma-separated-string-with-both-quoted-and-unquoted-strings
        private static string _regexString = "(?:^|,)(\"(?:[^\"]+|\"\")*\"|[^,]*)";

        // GET: PlayerContract
        public ActionResult Index()
        {
            var playersContracts = GetPlayersContracts();

            return View(playersContracts);
        }

        private IEnumerable<Player> GetPlayersContracts()
        {
            // create csvSplit Regex
            Regex csvSplit = new Regex(_regexString, RegexOptions.Compiled);

            var playersContracts = new List<Player>();

            using (var streamReader = new StreamReader(NFLPlayersContractsFilePath))
            {
                var header = streamReader.ReadLine();

                while (!streamReader.EndOfStream)
                {
                    var line   = streamReader.ReadLine();

                    if (string.IsNullOrEmpty(line))
                    {

                    }else {
                        ParsePlayerContract(csvSplit, playersContracts, line);
                    }
                }
            }

            return playersContracts;
        }

        private static void ParsePlayerContract(Regex csvSplit, List<Player> playersContracts, string line)
        {
            //var lineSplit = line.Split(','); // csv file, split by comma
            var lineValues = csvSplit.Matches(line); // csv file, split by comma

            var player = new Player() { CurrentContract = new PlayerContract() };

            for (int i = 0; i < lineValues.Count; i++)
            {
                var value = lineValues[i];
                var item = value.Value.TrimStart(',');
                // remove quotes 
                item = item.TrimStart('\"');
                item = item.TrimEnd('\"');


                switch (i)
                {
                    case 0:
                        player.PlayerName = item;
                        break;
                    case 1:
                        player.Position = item;
                        break;
                    case 2:
                        player.Team = item;
                        break;
                    case 3:
                        var totalValue = 0.0;
                        if (double.TryParse(item, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US").NumberFormat, out totalValue))
                        {

                        }
                        player.CurrentContract.TotalValue = totalValue;
                        break;
                    case 4:
                        // average year
                        break;
                    case 5:
                        var guaranteed = 0.0;
                        if (double.TryParse(item, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US").NumberFormat, out guaranteed))
                        {

                        }
                        player.CurrentContract.Guaranteed = guaranteed;
                        break;
                    case 6:
                        // average guaranteed year 
                        break;
                    case 7:
                        // http://stackoverflow.com/questions/2171615/how-to-convert-percentage-string-to-double
                        decimal guaranteedPct = 0;
                        item = item.Replace(CultureInfo.CurrentCulture.NumberFormat.PercentSymbol, "");
                        if (decimal.TryParse(item, out guaranteedPct))
                        {

                        }
                        player.CurrentContract.GuaranteedPct = guaranteedPct / 100M;
                        break;
                    default:
                        break;
                }
            }
            playersContracts.Add(player);
        }
    }
}