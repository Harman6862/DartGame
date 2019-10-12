using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace ZombieKill
{
    // GhostThrow KnifeingForm class definition inheriting Form class
    public partial class ZombieKillForm : Form
    {
        // Class Reference variables to be used
        // within below defined functions to access
        // defined members of the class
        readonly Player player;             // for referencing Player object
        readonly SoundPlayer soundPlayer;   // for referencing SoundPlayer object
        static Random random;               // for referncing Random object

        // Contructor for initializing the Form
        // and assign object reference to Class variables
        public ZombieKillForm()
        {
            InitializeComponent();
            player = new Player();
            soundPlayer = new SoundPlayer();
            random = new Random();
        }

        // Function for loading the Form
        // having alteration for specific form components
        // before actual form load
        private void ZombieKillForm_Load(object sender, EventArgs e)
        {
            tryLuck.Enabled = false;                // disabled Try Luck button
            playAgain.Enabled = false;              // disabled Play Again button
            throwKnife.Enabled = false;            // disabled Throw Knife button
            setknife.Enabled = true;              // enabled Set Knife button
        }

        // This function generates a random number between 0-5 and passes to SetKnife function
        // of Player class. Also, checks if the value is assigned or not via return type(true/false)
        //  and plays sound for setting the knife.
        private void SetKnife_Click(object sender, EventArgs e)
        {
            setknife.Enabled = false;             // Once Set Knife button is clicked
            tryLuck.Enabled = true;                 // it gets disabled and rest other buttons
            playAgain.Enabled = true;               // will be enabled
            throwKnife.Enabled = true;
            if (player.SetKnife(random.Next(0, 6)) == false)         // Next function takes min and max(exclusive)
            {                                                           // values to generated random numbers.
                message.Text = "Error while setting up knife.. Try again!!";   // Message to be displayed if any error
                setknife.Enabled = true;                              // occurs while assigning random number.
            }
            else
            {
                pictureBox1.Image = Image.FromFile(@"Resource\KillZombie.jpg");
                soundPlayer.SoundLocation = @"Resource\SetKnife.wav";    // Loading audio from Resource folder location
                soundPlayer.Play();                                         // and playing in new thread via Play().
                message.Text = "Knife is set now!!";
            }
        }

        // This function generates a random number between 0-5 and passes to TryLuck function
        // of Player class. Also, checks if the value is assigned or not via return type(true/false)
        // and plays sound after setting the luck value.
        private void TryLuck_Click(object sender, EventArgs e)
        {
            if (player.TryLuck(random.Next(0, 6)) == false)                  // Message to be displayed if any error
                message.Text = "Unable to spin your luck.. Try again!!";  // occurs while assigning random number
            else
            {
                soundPlayer.SoundLocation = @"Resource\LuckButtonSound.wav";
                soundPlayer.Play();
                message.Text = "Luck set.. Throw knife now";
            }
        }

        // This function cross-checks the knife position and luck value.
        // If both are equal then the zombie will be killed.
        // Else the player loses a chance or be dead if no chances are left.
        // Calculation of total win/lose points and total score for overall game session.
        private void ThrowKnife_Click(object sender, EventArgs e)
        {
            player.ThrowKnife();
            if (player.chance == -3)                                        // Specific chance value -3 to be 
            {                                                               // checked for win case
                soundPlayer.SoundLocation = @"Resource\KillZombieWinSound.wav";
                soundPlayer.Play();                                         // Plays win sound.
                win.Text = player.totalWins + "";                           // Sets win points on the win label.
                pictureBox1.Image = Image.FromFile(@"Resource\KillZombieWin.jpg");
                message.Text = "Congrats!!... You killed the Zombie...Wanna Play Again?";
                setknife.Enabled = false;
                tryLuck.Enabled = false;
                throwKnife.Enabled = false;
            }
            else if (player.chance == 0)                                    // For Game lose case check chance
            {                                                               // value to be 0.
                lose.Text = player.totalLoses + "";                         // Sets lose points on the lose label.
                pictureBox1.Image = Image.FromFile(@"Resource\KillZombieWelcome.jpg");
                message.Text = "You are dead... Click Play Again or close the window";
                setknife.Enabled = false;
                tryLuck.Enabled = false;
                throwKnife.Enabled = false;
                soundPlayer.SoundLocation = @"Resource\ZombieWins.wav";
                soundPlayer.Play();
            }
            else                                                          // Remaining chance case where number of chance
            {                                                             // is still left for the player.
                pictureBox1.Image = Image.FromFile(@"Resource\KillZombie1Chance.jpg");
                soundPlayer.SoundLocation = @"Resource\Throw.wav";
                soundPlayer.Play();
                message.Text = "You missed ..." + player.chance + " more chance left.."; // Displays number of chance left.
            }
            score.Text = player.totalScore + "";                         // Updates the total score for each win.
        }

        // This function resets the form components such as
        // enabling only Set Knife button and disabling the rest.
        // Resets the welcome message and image on 
        // picture box.
        private void PlayAgain_Click(object sender, EventArgs e)
        {
            message.Text = "Welcome to Kill Zombie Game!!";
            pictureBox1.Image = Image.FromFile(@"Resource\KillZombieWelcome.jpg");
            setknife.Enabled = true;
            tryLuck.Enabled = false;
            playAgain.Enabled = false;
            throwKnife.Enabled = false;
        }
    }
}
