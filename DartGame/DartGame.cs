using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace DartGame
{
    // DartGameForm class definition inheriting Form class
    public partial class DartGameForm : Form
    {
        // Class Reference variables to be used
        // within below defined functions to access
        // defined members of the class
        readonly Player player;             // for referencing Player object
        readonly SoundPlayer soundPlayer;   // for referencing SoundPlayer object
        static Random random;               // for referncing Random object

        // Contructor for initializing the Form
        // and assign object reference to Class variables
        public DartGameForm()
        {
            InitializeComponent();
            player = new Player();
            soundPlayer = new SoundPlayer();
            random = new Random();
        }

        // Function for loading the Form
        // having alteration for specific form components
        // before actual form load
        private void DartGameForm_Load(object sender, EventArgs e)
        {
            setDart.Enabled = false;                 // disabled Set Dart button
            playAgain.Enabled = false;              // disabled Play Again button
            throwDart.Enabled = false;            // disabled Throw Dart button
            setBoard.Enabled = true;              // enabled Set Board button
        }

        // This function generates a random number between 0-5 and passes to SetBoard function
        // of Player class. Also, checks if the value is assigned or not via return type(true/false)
        //  and plays sound for setting the dart board position.
        private void SetBoard_Click(object sender, EventArgs e)
        {
            setBoard.Enabled = false;             // Once Set Board button is clicked
            setDart.Enabled = true;                 // it gets disabled and rest other buttons
            playAgain.Enabled = true;               // will be enabled
            throwDart.Enabled = true;
            if (player.SetBoard(random.Next(0, 6)) == false)         // Next function takes min and max(exclusive)
            {                                                           // values to generated random numbers.
                message.Text = "Error while setting up DartBoard.. Try again!!";   // Message to be displayed if any error
                setBoard.Enabled = true;                              // occurs while assigning random number.
            }
            else
            {
                pictureBox1.Image = Image.FromFile(@"Resource\DartWelcome.jpg");
                soundPlayer.SoundLocation = @"Resource\SetBoard.wav";    // Loading audio from Resource folder location
                soundPlayer.Play();                                         // and playing in new thread via Play().
                message.Text = "DartBoard is set now!!";
            }
        }

        // This function generates a random number between 0-5 and passes to SetDart function
        // of Player class. Also, checks if the value is assigned or not via return type(true/false)
        // and plays sound after setting the dart position.
        private void SetDart_Click(object sender, EventArgs e)
        {
            if (player.SetDart(random.Next(0, 6)) == false)                  // Message to be displayed if any error
                message.Text = "Unable to set dart position.. Try again!!";  // occurs while assigning random number
            else
            {
                soundPlayer.SoundLocation = @"Resource\SetDart.wav";
                soundPlayer.Play();
                message.Text = "Dart position is set.. Throw Dart now";
            }
        }

        // This function cross-checks the dart board position and dart position.
        // If both are equal then the dart will hit center.
        // Else the player loses a chance or game will be over if no chances are left.
        // Calculation of total win/lose points and total score for overall game session.
        private void ThrowDart_Click(object sender, EventArgs e)
        {
            player.ThrowDart();
            if (player.chance == -3)                                        // Specific chance value -3 to be 
            {                                                               // checked for win case
                soundPlayer.SoundLocation = @"Resource\DartWinSound.wav";
                soundPlayer.Play();                                         // Plays win sound.
                win.Text = player.totalWins + "";                           // Sets win points on the win label.
                pictureBox1.Image = Image.FromFile(@"Resource\DartWin.jpg");
                message.Text = "Congrats!!... Dart aimed at the center...Wanna Play Again?";
                setBoard.Enabled = false;
                setDart.Enabled = false;
                throwDart.Enabled = false;
            }
            else if (player.chance == 0)                                    // For Game lose case check chance
            {                                                               // value to be 0.
                lose.Text = player.totalLoses + "";                         // Sets lose points on the lose label.
                pictureBox1.Image = Image.FromFile(@"Resource\Dart1Chance.jpg");
                message.Text = "Game Over... Click Play Again or close the window";
                setBoard.Enabled = false;
                setDart.Enabled = false;
                throwDart.Enabled = false;
                soundPlayer.SoundLocation = @"Resource\GameOver.wav";
                soundPlayer.Play();
            }
            else                                                          // Remaining chance case where number of chance
            {                                                             // is still left for the player.
                pictureBox1.Image = Image.FromFile(@"Resource\Dart1Chance.jpg");
                soundPlayer.SoundLocation = @"Resource\Dart.wav";
                soundPlayer.Play();
                message.Text = "You missed ..." + player.chance + " more chance left.."; // Displays number of chance left.
            }
            score.Text = player.totalScore + "";                         // Updates the total score for each win.
        }

        // This function resets the form components such as
        // enabling only Set Board button and disabling the rest.
        // Resets the welcome message and image on 
        // picture box.
        private void PlayAgain_Click(object sender, EventArgs e)
        {
            message.Text = "Welcome to Dart Game!!";
            pictureBox1.Image = Image.FromFile(@"Resource\DartWelcome.jpg");
            setBoard.Enabled = true;
            setDart.Enabled = false;
            playAgain.Enabled = false;
            throwDart.Enabled = false;
        }
    }
}
