using CasinoRoyale.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasinoRoyale
{
    public partial class MainMenu : Form
    {
        private readonly string directory = Directory.GetCurrentDirectory();
        private int[] computerDiceResults;
        private int currentDice;
        private string[] dataReadFromFile;

        public MainMenu()
        {
            InitializeComponent();
            // Create round corners
            Region = Region.FromHrgn(CommonControls.CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            // Set form style
            CommonControls.FormStyle(this);
            // Fade In Effect
            timerFadeIn.Enabled = true;
            lblComputerKind.Visible = false;
            lblHumanKind.Visible = false;
            timerChangeDieImages.Enabled = true;
            // Read text file to get number of wins each
            dataReadFromFile = ReadTextFile();
            DisplayWinsData();
            ReadGameDescription();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void timerFadeIn_Tick(object sender, EventArgs e)
        {
            if (Opacity < 100)
                CommonControls.FadeInEffect(this);
            else
                timerFadeIn.Enabled = false;
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tbPgPlay;
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            btnRollComputerDies.Enabled = true;
            // Set correct directory path, to images folder
            string directoryPath = directory.Substring(0, directory.IndexOf("\\bin"));
            ChangeGameModeImages(directoryPath, "unlock");
            btnStartGame.Enabled = false;
            lblComputerKind.Visible = false;
            lblHumanKind.Visible = false;
        }

        private void ChangeGameModeImages(string directoryPath, string gameMode)
        {
            // Change computer roll images
            string imgURL = (gameMode.Equals("unlock")) ? directoryPath + "\\imgs\\unlocked.png" : directoryPath + "\\imgs\\locked.png";
            picBoxComputerDie1.Image = Image.FromFile(imgURL);
            picBoxComputerDie1.SizeMode = PictureBoxSizeMode.CenterImage;
            picBoxComputerDie2.Image = Image.FromFile(imgURL);
            picBoxComputerDie2.SizeMode = PictureBoxSizeMode.CenterImage;
            picBoxComputerDie3.Image = Image.FromFile(imgURL);
            picBoxComputerDie3.SizeMode = PictureBoxSizeMode.CenterImage;
            picBoxComputerDie4.Image = Image.FromFile(imgURL);
            picBoxComputerDie4.SizeMode = PictureBoxSizeMode.CenterImage;
            picBoxComputerDie5.Image = Image.FromFile(imgURL);
            picBoxComputerDie5.SizeMode = PictureBoxSizeMode.CenterImage;

            // Change human roll images
            picBoxHumanDie1.Image = Image.FromFile(imgURL);
            picBoxHumanDie1.SizeMode = PictureBoxSizeMode.CenterImage;
            picBoxHumanDie2.Image = Image.FromFile(imgURL);
            picBoxHumanDie2.SizeMode = PictureBoxSizeMode.CenterImage;
            picBoxHumanDie3.Image = Image.FromFile(imgURL);
            picBoxHumanDie3.SizeMode = PictureBoxSizeMode.CenterImage;
            picBoxHumanDie4.Image = Image.FromFile(imgURL);
            picBoxHumanDie4.SizeMode = PictureBoxSizeMode.CenterImage;
            picBoxHumanDie5.Image = Image.FromFile(imgURL);
            picBoxHumanDie5.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        public void ChangeComputerRolledDice(int position, int rolledDice)
        {
            // Set correct directory path, to images folder
            string directoryPath = directory.Substring(0, directory.IndexOf("\\bin")),
                   currentDiceImage = "\\imgs\\dice_dots_" + rolledDice + ".png"; 
            switch (position)
            {
                case 0:
                    picBoxComputerDie1.Image = Image.FromFile(directoryPath + currentDiceImage);
                    picBoxComputerDie1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 1:
                    picBoxComputerDie2.Image = Image.FromFile(directoryPath + currentDiceImage);
                    picBoxComputerDie2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    picBoxComputerDie3.Image = Image.FromFile(directoryPath + currentDiceImage);
                    picBoxComputerDie3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    picBoxComputerDie4.Image = Image.FromFile(directoryPath + currentDiceImage);
                    picBoxComputerDie4.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    picBoxComputerDie5.Image = Image.FromFile(directoryPath + currentDiceImage);
                    picBoxComputerDie5.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
        }

        public void ChangeHumanRolledDice(int position, int rolledDice)
        {
            // Set correct directory path, to images folder
            string directoryPath = directory.Substring(0, directory.IndexOf("\\bin")),
                   currentDiceImage = "\\imgs\\dice_dots_" + rolledDice + ".png";
            switch (position)
            {
                case 0:
                    picBoxHumanDie1.Image = Image.FromFile(directoryPath + currentDiceImage);
                    picBoxHumanDie1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 1:
                    picBoxHumanDie2.Image = Image.FromFile(directoryPath + currentDiceImage);
                    picBoxHumanDie2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    picBoxHumanDie3.Image = Image.FromFile(directoryPath + currentDiceImage);
                    picBoxHumanDie3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    picBoxHumanDie4.Image = Image.FromFile(directoryPath + currentDiceImage);
                    picBoxHumanDie4.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    picBoxHumanDie5.Image = Image.FromFile(directoryPath + currentDiceImage);
                    picBoxHumanDie5.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
        }

        private void btnRollComputerDies_Click(object sender, EventArgs e)
        {
            StartGame startGame = new StartGame("Computer", this);
            for (int i = 1; i < +6; i++)
                startGame.UpdateGamePlay();
            lblComputerScore.Text = startGame.GetPlayerScore().ToString();
            computerDiceResults = startGame.GetDiceResults();

            btnRollHumanDies.Enabled = true;
            btnRollComputerDies.Enabled = false;
        }

        private void btnRollHumanDies_Click(object sender, EventArgs e)
        {
            StartGame startGame = new StartGame("Human", this);
            for (int i = 1; i < +6; i++)
                startGame.UpdateGamePlay();
            lblHumanScore.Text = startGame.GetPlayerScore().ToString();
            int[] humanDiceResults = startGame.GetDiceResults();

            Winner winner = new Winner(computerDiceResults, humanDiceResults);
            string[] winnerDetails = winner.DetermineWinner().Split('#');
            
            // Update lblComputerKind
            if (winnerDetails[0].Equals("Pair") || winnerDetails[0].Equals("2 Pairs"))
                lblComputerKind.Text = winnerDetails[0] + " of " + winnerDetails[1];
            else
                lblComputerKind.Text = winnerDetails[0] + ": " + winnerDetails[1];
            lblComputerKind.Visible = true;
            // Update lblHumanKind
            if (winnerDetails[2].Equals("Pair") || winnerDetails[2].Equals("2 Pairs"))
            {
                lblHumanKind.Location = new Point(712, 144);
                lblHumanKind.Text = winnerDetails[2] + " of " + winnerDetails[3];
            }
            else
            {
                lblHumanKind.Location = new Point(654, 144);
                lblHumanKind.Text = winnerDetails[2] + ": " + winnerDetails[3];
            }
            lblHumanKind.Visible = true;
            // Update lblWinner
            lblWinner.Text = "Winner: " + winnerDetails[4];

            // Update textfile
            int computerWins = int.Parse(dataReadFromFile[1]),
                humanWins = int.Parse(dataReadFromFile[3]);

            if (winnerDetails[4].Equals("Computer"))
                computerWins += 1;
            else if (winnerDetails[4].Equals("Human"))
                humanWins += 1;

            WriteTextFile(computerWins, humanWins);

            btnRestartGame.Enabled = true;
            btnRollHumanDies.Enabled = false;
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timerFadeOut_Tick(object sender, EventArgs e)
        {
            if (Opacity > 0)
                CommonControls.FadeOutEffect(this);
            timerExit.Enabled = true;
        }

        private void timerExit_Tick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picBoxMainExit_Click(object sender, EventArgs e)
        {
            timerChangeDieImages.Enabled = false;
            timerFadeOut.Enabled = true;
        }

        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            btnStartGame.Enabled = true;
            lblComputerKind.Visible = false;
            lblHumanKind.Visible = false;
            lblComputerScore.Text = "0";
            lblHumanScore.Text = "0";
            lblWinner.Text = "Results: None";
            // Set correct directory path, to images folder
            string directoryPath = directory.Substring(0, directory.IndexOf("\\bin"));
            ChangeGameModeImages(directoryPath, "locked");
            btnRestartGame.Enabled = false;
        }

        private void ChangeDieImage(int diceNumber)
        {
            // Set correct directory path, to images folder
            string directoryPath = directory.Substring(0, directory.IndexOf("\\bin")),
                   currentDiceImage = "\\imgs\\dice_dots_" + diceNumber + ".png";

            picBoxChangeDieImages.Image = Image.FromFile(directoryPath + currentDiceImage);
            picBoxChangeDieImages.SizeMode = PictureBoxSizeMode.Zoom;

            }

        private void timerChangeDieImages_Tick(object sender, EventArgs e)
        {
            currentDice = new Random().Next(1, 6 + 1);
            ChangeDieImage(currentDice);
        }

        private void panel10_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        //private string[] ReadTextFile()
        //{
        //    // Set correct directory path, to images folder
        //    string directoryPath = directory.Substring(0, directory.IndexOf("\\bin")),
        //          fileDirectory = directoryPath + "\\textfile\\recordWins.txt",
        //          textRead = "";
        //    try
        //    {
        //        using (StreamReader streamReader = new StreamReader(fileDirectory))
        //        {
        //            textRead = streamReader.ReadLine();
        //        } 
        //    } catch (Exception e)
        //    {
        //        textRead = "Computer#0#Human#0";
        //    }

        //    return textRead.Split('#');
        //}

        private string[] ReadTextFile()
        {
            try
            {
                string fileDirectory = Path.Combine(directory, "textfile", "recordWins.txt");

                if (File.Exists(fileDirectory))
                {
                    string textRead = File.ReadAllText(fileDirectory);
                    return textRead.Split('#');
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            // Return default values in case of any exception or file absence
            return new string[] { "Computer", "0", "Human", "0" };
        }

        //private void WriteTextFile(int computerWins, int humanWins)
        //{
        //    // Set correct directory path, to images folder
        //    string directoryPath = directory.Substring(0, directory.IndexOf("\\bin")),
        //          fileDirectory = directoryPath + "\\textfile\\recordWins.txt",
        //          textRead = "";

        //    using (StreamWriter streamWriter = new StreamWriter(fileDirectory))
        //    {
        //        streamWriter.WriteLine("Computer#" + computerWins + "#Human#" + humanWins);
        //    }
        //}

        private void WriteTextFile(int computerWins, int humanWins)
        {
            try
            {
                string fileDirectory = Path.Combine(directory, "textfile", "recordWins.txt");

                int existingComputerWins = 0;
                int existingHumanWins = 0;

                if (File.Exists(fileDirectory))
                {
                    string[] existingData = File.ReadAllText(fileDirectory).Split('#');

                    if (existingData.Length >= 4)
                    {
                        // Parsing the existing wins from the file
                        int.TryParse(existingData[1], out existingComputerWins);
                        int.TryParse(existingData[3], out existingHumanWins);
                    }
                }
                else
                {
                    // Create the directory if it doesn't exist
                    Directory.CreateDirectory(Path.GetDirectoryName(fileDirectory));
                    // Create the file
                    File.Create(fileDirectory).Close();
                }

                // Adding new wins to existing wins
                int totalComputerWins = existingComputerWins + computerWins;
                int totalHumanWins = existingHumanWins + humanWins;

                using (StreamWriter streamWriter = new StreamWriter(fileDirectory, false))
                {
                    string lineToWrite = $"Computer#{totalComputerWins}#Human#{totalHumanWins}";
                    streamWriter.WriteLine(lineToWrite);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while writing to the file: {ex.Message}");
                // Handle the error accordingly, throw an exception, log, etc.
            }
        }

        private void DisplayWinsData()
        {
            if (dataReadFromFile.Length > 0)
            {
                lblTotalComputerWins.Text = dataReadFromFile[1];
                lblTotalHumanWins.Text = dataReadFromFile[3];
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedTab == tbPgHome)
            {
                // Read text file to get number of wins each
                dataReadFromFile = ReadTextFile();
                DisplayWinsData();
                timerChangeDieImages.Enabled = true;
            } else
                timerChangeDieImages.Enabled = false;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string message = "This is our main menu. Here you have a variety of options to choose from and the freedom to move around the game as you please. " + 
                "On the left hand side, we display records of previous games (games won only by both Computer and Human players), thereafter, we randomly roll a dice and display it's output.";
            CommonControls.DisplayCustomMessage(this, message);
        }

        private void btnDeveloper_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tbPgDeveloper;
        }

        private void btnGameDescription_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tbPgGameDescription;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            picBoxMainExit_Click(sender, e);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tbPgHome;
        }

        private void btnDeveloperPlay_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tbPgPlay;
        }

        private void btnDeveloperHelp_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDeveloperExit_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tbPgGameDescription;
        }

        private void ReadGameDescription()
        {
            // Set correct directory path, to images folder
            string directoryPath = directory.Substring(0, directory.IndexOf("\\bin")),
                  fileDirectory = directoryPath + "\\textfile\\gameDescription.txt",
                  textRead = File.ReadAllText(fileDirectory);
            richTxtBoxGameDescription.Text = textRead;
            richTxtBoxGameDescription.SelectionAlignment = HorizontalAlignment.Center;
        }
    }
}
