using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace GhostBowling
{
    // GhostBowlingForm class definition inheriting Form class
    public partial class GhostBowlingForm : Form
    {
        // Class Reference variables to be used
        // within below defined functions to access
        // defined members of the class
        readonly Player player;             // for referencing Player object
        readonly SoundPlayer soundPlayer;   // for referencing SoundPlayer object
        static Random random;               // for referncing Random object

        // Contructor for initializing the Form
        // and assign object reference to Class variables
        public GhostBowlingForm()
        {
            InitializeComponent();
            player = new Player();
            soundPlayer = new SoundPlayer();
            random = new Random();
        }

        // Function for loading the Form
        // having alteration for specific form components
        // before actual form load
        private void GhostBowlingForm_Load(object sender, EventArgs e)
        {
            tryLuck.Enabled = false;           // disabled Spin Chambers button
            playAgain.Enabled = false;              // disabled Play Again button
            bowl.Enabled = false;                   // disabled Bowl button
            setTheBall.Enabled = true;              // enabled Load Bullet button
        }

        // This function generates a random number between 0-5 and passes to SetTheBall function
        // of Player class. Also, checks if the value is assigned or not via return type(true/false)
        //  and plays sound for loading the bullet.
        private void SetTheBall_Click(object sender, EventArgs e)
        {
            setTheBall.Enabled = false;             // Once the Load Bullet button is clicked
            tryLuck.Enabled = true;            // it gets disabled and rest other buttons
            playAgain.Enabled = true;               // will be enabled
            bowl.Enabled = true;
            if (player.SetTheBall(random.Next(0, 6)) == false)         // Next function takes min and max(exclusive)
            {                                                           // values to generated randome numbers.
                message.Text = "Error while setting up ball.. Try again!!";   // Message to be displayed if any error
                setTheBall.Enabled = true;                              // occurs while assigning random number.
            }
            else
            {
                pictureBox1.Image = Image.FromFile(@"Resource\GhostBowling.jpg");
                soundPlayer.SoundLocation = @"Resource\SetBallSound.wav";    // Loading audio from Resource folder location
                soundPlayer.Play();                                         // and playing in new thread via Play().
                message.Text = "Ball is set now!!";
            }
        }

        // This function generates a random number between 0-5 and passes to TryLuck function
        // of Player class. Also, checks if the value is assigned or not via return type(true/false)
        // and plays sound for spinning the chambers.
        private void TryLuck_Click(object sender, EventArgs e)
        {
            if (player.TryLuck(random.Next(0, 6)) == false)                  // Message to be displayed if any error
                message.Text = "Unable to spin your luck.. Try again!!";  // occurs while assigning random number
            else
            {
                soundPlayer.SoundLocation = @"Resource\LuckButtonSound.wav";
                soundPlayer.Play();
                message.Text = "Luck set.. Bowl now";
            }
        }

        // This function cross-checks the spin value and bullet position.
        // If both are equal then the monster will be killed.
        // Else the player loses a chance or be dead if no chances are left.
        // Calculation of total win/lose points and total score for overall game session.
        private void Bowl_Click(object sender, EventArgs e)
        {
            player.Bowl();
            if (player.chance == -3)                                        // Specific chance value -3 to be 
            {                                                               // checked for win case
                soundPlayer.SoundLocation = @"Resource\GhostBowlingWinSound.wav";
                soundPlayer.Play();                                         // Plays gun bullet fire sound.
                win.Text = player.totalWins + "";                           // Sets win points on the win label.
                pictureBox1.Image = Image.FromFile(@"Resource\GhostBowlingWin.jpg");
                message.Text = "Whoa!!... You killed all the Ghosts...Wanna Play Again?";
                setTheBall.Enabled = false;
                tryLuck.Enabled = false;
                bowl.Enabled = false;
            }
            else if (player.chance == 0)                                    // For Game lose case check chance
            {                                                               // value to be 0.
                lose.Text = player.totalLoses + "";                           // Sets lose points on the lose label.
                message.Text = "You are dead... Click Play Again or close the window";
                setTheBall.Enabled = false;
                tryLuck.Enabled = false;
                bowl.Enabled = false;
                soundPlayer.SoundLocation = @"Resource\GhostBowlingSpookySound.wav";
                soundPlayer.Play();
            }
            else                                                          // Remaining chance case where number of chance
            {                                                             // is still left for the player.
                pictureBox1.Image = Image.FromFile(@"Resource\GhostBowling1Chance.jpg");
                soundPlayer.SoundLocation = @"Resource\BowlingSound.wav";
                soundPlayer.Play();
                message.Text = "You missed ..." + player.chance + " more chance left.."; // Displays number of chance left.
            }
            score.Text = player.totalScore + "";                         // Updates the total score for each win.
        }

        // This function resets the form components such as
        // enabling only Load Bullet button and disabling the rest.
        // Resets the welcome message and Monster image on 
        // picture box.
        private void PlayAgain_Click(object sender, EventArgs e)
        {
            message.Text = "Welcome to the Ghost Bowling!!";
            pictureBox1.Image = Image.FromFile(@"Resource\GhostBowlingWelcome.jpg");
            setTheBall.Enabled = true;
            tryLuck.Enabled = false;
            playAgain.Enabled = false;
            bowl.Enabled = false;
        }



    }
}
