using System;
using System.Collections.Generic;


namespace CasinoRoyale.classes
{
    class StartGame
    {
        private Random random;
        private MainMenu mainMenu;
        private int position, playerScore, diceRolled;
        private int[] diceResults = new int[6];
        private string player;
      
        public StartGame(string player, MainMenu mainMenu)
        {
            random = new Random();
            position = -1;
            playerScore = 0;
            diceRolled = 0;     
            this.player = player;
            this.mainMenu = mainMenu;
        }

        private int RollDice()
        {
            // Increment position of rolled dice and return dice rolled
            position++;
            return random.Next(1, 6 + 1);
        }

        public void SetPlayerScore()
        {
            playerScore += diceRolled;
        }

        public int GetPlayerScore()
        {
            return playerScore;
        }

        public void UpdateGamePlay()
        {
            diceRolled = RollDice();
            SetPlayerScore();
            diceResults[position] = diceRolled;
            SetRolledDiceImage();
        }

        private void SetRolledDiceImage()
        {
            if (player.Equals("Computer"))
                mainMenu.ChangeComputerRolledDice(position, diceRolled);
            else
                mainMenu.ChangeHumanRolledDice(position, diceRolled);
        }

        public int[] GetDiceResults()
        {
            return diceResults;
        }
    }
}
