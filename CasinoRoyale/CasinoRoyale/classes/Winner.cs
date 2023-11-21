using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoRoyale.classes
{
    class Winner
    {
        private int[] computerDiceResults, humanDiceResults;
        private Dictionary<string, int> computerOccurencies, humanOccurencies;
  
        public Winner(int[] computerDiceResults, int[] humanDiceResults)
        {
            this.computerDiceResults = computerDiceResults;
            this.humanDiceResults = humanDiceResults;
            InitializeDictionaries();
        }

        private void InitializeDictionaries()
        {
            string[] diceNumbers = { "1", "2", "3", "4", "5", "6" };
            computerOccurencies = new Dictionary<string, int>();
            humanOccurencies = new Dictionary<string, int>();
            foreach (string key in diceNumbers)
            {
                computerOccurencies.Add(key, 0);
                humanOccurencies.Add(key, 0);
            }
        }

        private void CountOccurencies(int[] diceResults, string player)
        {
             for (int i = 0; i < diceResults.Length; i++)
                if (player.Equals("Computer"))
                    switch (diceResults[i])
                    {
                        case 1:
                            computerOccurencies["1"] += 1;
                            break;
                        case 2:
                            computerOccurencies["2"] += 1;
                            break;
                        case 3:
                            computerOccurencies["3"] += 1;
                            break;
                        case 4:
                            computerOccurencies["4"] += 1;
                            break;
                        case 5:
                            computerOccurencies["5"] += 1;
                            break;
                        case 6:
                            computerOccurencies["6"] += 1;
                            break;
                    }
                else
                    switch (diceResults[i])
                    {
                        case 1:
                            humanOccurencies["1"] += 1;
                            break;
                        case 2:
                            humanOccurencies["2"] += 1;
                            break;
                        case 3:
                            humanOccurencies["3"] += 1;
                            break;
                        case 4:
                            humanOccurencies["4"] += 1;
                            break;
                        case 5:
                            humanOccurencies["5"] += 1;
                            break;
                        case 6:
                            humanOccurencies["6"] += 1;
                            break;
                    }
        }

        private string IsOfAKind(int[] diceResults, Dictionary<string, int> dictionary, string player)
        {
            CountOccurencies(diceResults, player);
            string details = "None", key = "-1";
            int currKey = 0; int times = 0;
            foreach (KeyValuePair<string, int> keyValue in dictionary)
            {
                if (keyValue.Value == 5)
                {
                    details = "Five of a Kind";
                    key = keyValue.Key;
                    break;
                }
                else if (keyValue.Value == 4)
                {
                    details = "Four of a Kind";
                    key = keyValue.Key;
                    break;
                }
                else if (keyValue.Value == 3)
                {
                    details = "Three of a Kind";
                    key = keyValue.Key;
                    break;
                }
                else if (keyValue.Value == 2)
                {
                    if (times > 0) {
                        int now = int.Parse(keyValue.Key);
                        details = "2 Pairs";
                        key = (now > currKey) ? keyValue.Key : currKey.ToString();
                    }
                    else
                    {
                        key = keyValue.Key;
                        details = "Pair";
                        times++;
                    }
                    currKey = int.Parse(keyValue.Key);

                } 
            }
            return details + "#" + key;
        }

        private string CheckDraw(int afterComputer, int afterHuman)
        {
            /*
                * This code checks which rolled dice is greater than the other
                * If both dies (Computer) and (Human) are equal, then its a split draw
             */

            string winner = "";
            if (afterComputer > afterHuman)
                winner = "Computer";
            else if (afterComputer == afterHuman)
                winner = "Split Draw";
            else
                winner = "Human";
            return winner;
        }

        private string FiveKind(string beforeComputer, string beforeHuman, int afterComputer, int afterHuman)
        {
            string winner = "";

            if (beforeComputer.Equals("Five of a Kind") && !beforeHuman.Equals("Five of a Kind"))
                winner = "Computer";
            else if (!beforeComputer.Equals("Five of a Kind") && beforeHuman.Equals("Five of a Kind"))
                winner = "Human";
            else if (beforeComputer.Equals("Five of a Kind") && beforeHuman.Equals("Five of a Kind"))
                winner = CheckDraw(afterComputer, afterHuman);
            else
                winner = FourKind(beforeComputer, beforeHuman, afterComputer, afterHuman);

            return winner;
        }

        private string FourKind(string beforeComputer, string beforeHuman, int afterComputer, int afterHuman)
        {
            string winner = "";

            if (beforeComputer.Equals("Four of a Kind") && !beforeHuman.Equals("Four of a Kind"))
                winner = "Computer";
            else if (!beforeComputer.Equals("Four of a Kind") && beforeHuman.Equals("Four of a Kind"))
                winner = "Human";
            else if (beforeComputer.Equals("Four of a Kind") && beforeHuman.Equals("Four of a Kind"))
                winner = CheckDraw(afterComputer, afterHuman);
            else
                winner = ThreeKind(beforeComputer, beforeHuman, afterComputer, afterHuman);

            return winner;
        }

        private string ThreeKind(string beforeComputer, string beforeHuman, int afterComputer, int afterHuman)
        {
            string winner = "";

            if (beforeComputer.Equals("Three of a Kind") && !beforeHuman.Equals("Three of a Kind"))
                winner = "Computer";
            else if (!beforeComputer.Equals("Three of a Kind") && beforeHuman.Equals("Three of a Kind"))
                winner = "Human";
            else if (beforeComputer.Equals("Three of a Kind") && beforeHuman.Equals("Three of a Kind"))
                winner = CheckDraw(afterComputer, afterHuman);
            else
                winner = Pair(beforeComputer, beforeHuman, afterComputer, afterHuman);

            return winner;
        }

        private string Pair(string beforeComputer, string beforeHuman, int afterComputer, int afterHuman)
        {
            string winner = "";
            if ((beforeComputer.Equals("Pair") || beforeComputer.Equals("2 Pairs")) && (!beforeHuman.Equals("Pair") && !beforeHuman.Equals("2 Pairs")))
                winner = "Human";
            else if ((beforeComputer.Equals("Pair") || beforeComputer.Equals("2 Pairs")) && (beforeHuman.Equals("Pair") || beforeHuman.Equals("2 Pairs")))
                winner = CheckDraw(afterComputer, afterHuman);
            else
                winner = "Computer";

            return winner;
        }

        public string DetermineWinner()
        {
            // Get is of a kind
            string computerKind = IsOfAKind(computerDiceResults, computerOccurencies, "Computer"),
                   humanKind = IsOfAKind(humanDiceResults, humanOccurencies, "Human"),
                   beforeComputer = computerKind.Substring(0, computerKind.IndexOf("#")),
                   afterComputer = computerKind.Substring(computerKind.IndexOf("#") + 1),
                   beforeHuman = humanKind.Substring(0, humanKind.IndexOf("#")),
                   afterHuman = humanKind.Substring(humanKind.IndexOf("#") + 1);
            Console.Write(afterComputer + " " + afterHuman + "\n");
            //Determine Winner
            string winnersDetails = "";
            if (beforeComputer.Equals("None") && !beforeHuman.Equals("None"))
                winnersDetails = "Human";
            else if (!beforeComputer.Equals("None") && beforeHuman.Equals("None"))
                winnersDetails = "Computer";
            else if (beforeComputer.Equals("None") && beforeHuman.Equals("None"))
                winnersDetails = "Split Draw";
            else
                winnersDetails = FiveKind(beforeComputer, beforeHuman, int.Parse(afterComputer), int.Parse(afterHuman));

            return computerKind + "#" + humanKind + "#" + winnersDetails;
        }
    }
}
