///*
//    * This class will recieve an arry of all the computer rolled dice results
//    * The class will use these recieved dice results and create 4 boolean methods
//    * to determine if the comouter rolled dice results are:
//            * Is five of a kind
//            * Is Four of a kind
//            * Is Three of a kinf
//            * Is Pair
// */

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CasinoRoyale.classes
//{
//    class ComputerResults
//    {
//        private int[] computerDiceResults, computerDiceResultOccurencies;

//        public ComputerResults(int[] computerDiceResults)
//        {
//            this.computerDiceResults = computerDiceResults;
//        }

//        public bool IsFiveKind(int diceNum)
//        {
//            int found = 0;
//            for (int i = 0; i < computerDiceResults.Length; i++)
//            {
//                for (int j = 1; j < computerDiceResults[i]; j++)
//                    if (computerDiceResults[j] == diceNum)
//                        found++;
//                    else
//                        break; // Five of a kind not found
//            }
//            return (found == 5) ? true : false;
//        }

//        public bool IsFourKind(int diceNum)
//        {
//            int found = 0;
//            for (int i = 0; i < computerDiceResults.Length; i++)
//            {
//                for (int j = 1; j < computerDiceResults[i]; j++)
//                    if (computerDiceResults[j] == diceNum)
//                        found++;
//                    else
//                        break; // Four of a kind not found
//            }
//            return (found == 4) ? true : false;
//        }

//        public bool IsThreeKind(int diceNum)
//        {
//            int found = 0;
//            for (int i = 0; i < computerDiceResults.Length; i++)
//            {
//                for (int j = 1; j < computerDiceResults[i]; j++)
//                    if (computerDiceResults[j] == diceNum)
//                        found++;
//                    else
//                        break; // Four of a kind not found
//            }
//            return (found == 3) ? true : false;
//        }

//        public bool isPair(int diceNum)
//        {
//            int found = 0;
//            for (int i = 0; i < computerDiceResults.Length; i++)
//            {
//                for (int j = 1; j < computerDiceResults[i]; j++)
//                    if (computerDiceResults[j] == diceNum)
//                        found++;
//                    else
//                        break; // Four of a kind not found
//            }
//            return (found > 2) ? true : false;
//        }

//    }
//}


using System;
using System.Linq;

namespace CasinoRoyale.classes
{
    class ComputerResults
    {
        private int[] computerDiceResults;

        public ComputerResults(int[] computerDiceResults)
        {
            this.computerDiceResults = computerDiceResults;
        }

        public bool IsFiveKind(int diceNum)
        {
            int found = computerDiceResults.Count(d => d == diceNum);
            return found >= 5;
        }

        public bool IsFourKind(int diceNum)
        {
            int found = computerDiceResults.Count(d => d == diceNum);
            return found >= 4;
        }

        public bool IsThreeKind(int diceNum)
        {
            int found = computerDiceResults.Count(d => d == diceNum);
            return found >= 3;
        }

        public bool IsPair(int diceNum)
        {
            int found = computerDiceResults.Count(d => d == diceNum);
            return found >= 2;
        }
    }
}
