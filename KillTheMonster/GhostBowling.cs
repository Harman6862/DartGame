using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace GhostBowling
{
    // KillMonsterForm class definition inheriting Form class
    public partial class GhostBowling : Form
    {
        // Class Reference variables to be used
        // within below defined functions to access
        // defined members of the class
        readonly Player player;             // for referencing Player object
        readonly SoundPlayer soundPlayer;   // for referencing SoundPlayer object
        static Random random;               // for referncing Random object

        // Contructor for initializing the Form
        // and assign object reference to Class variables
        public GhostBowling()
        {
            InitializeComponent();
            player = new Player();
            soundPlayer = new SoundPlayer();
            random = new Random();
        }

        // Function for loading the Form
        // having alteration for specific form components
        // before actual form load
        private void KillMonsterForm_Load(object sender, EventArgs e)
        {
            spinChambers.Enabled = false;           // disabled Spin Chambers button
            playAgain.Enabled = false;              // disabled Play Again button
            fire.Enabled = false;                   // disabled Fire button
            loadBullet.Enabled = true;              // enabled Load Bullet button
        }

        // This function generates a random number between 0-5 and passes to LoadBullets function
        // of Player class. Also, checks if the value is assigned or not via return type(true/false)
        //  and plays sound for loading the bullet.
        private void LoadBullet_Click(object sender, EventArgs e)
        {
            loadBullet.Enabled = false;             // Once the Load Bullet button is clicked
            spinChambers.Enabled = true;            // it gets disabled and rest other buttons
            playAgain.Enabled = true;               // will be enabled
            fire.Enabled = true;
            if (player.LoadBullets(random.Next(0, 6)) == false)         // Next function takes min and max(exclusive)
            {                                                           // values to generated randome numbers.
                message.Text = "Error Loading Bullets.. Try again!!";   // Message to be displayed if any error
                loadBullet.Enabled = true;                              // occurs while assigning random number.
            }
            else
            {
                soundPlayer.SoundLocation = @"Resource\LoadBullets.wav";    // Loading audio from Resource folder location
                soundPlayer.Play();                                         // and playing in new thread via Play().
                message.Text = "Bullet Loaded Successfully!!";
            }
        }

        // This function generates a random number between 0-5 and passes to SpinChambers function
        // of Player class. Also, checks if the value is assigned or not via return type(true/false)
        // and plays sound for spinning the chambers.
        private void SpinChambers_Click(object sender, EventArgs e)
        {
            if (player.SpinChambers(random.Next(0, 6)) == false)                  // Message to be displayed if any error
                message.Text = "OOps Spinning the chamber failed.. Try again!!";  // occurs while assigning random number
            else
            {
                soundPlayer.SoundLocation = @"Resource\SpinChambers.wav";
                soundPlayer.Play();
                message.Text = "Chambers Spinned.. Try your luck now";
            }
        }

        // This function cross-checks the spin value and bullet position.
        // If both are equal then the monster will be killed.
        // Else the player loses a chance or be dead if no chances are left.
        // Calculation of total win/lose points and total score for overall game session.
        private void Fire_Click(object sender, EventArgs e)
        {
            player.Fire();
            if (player.chance == -3)                                        // Specific chance value -3 to be 
            {                                                               // checked for win case
                soundPlayer.SoundLocation = @"Resource\GunBulletFire.wav";
                soundPlayer.Play();                                         // Plays gun bullet fire sound.
                win.Text = player.totalWins + "";                           // Sets win points on the win label.
                pictureBox1.Image = Image.FromFile(@"Resource\KilledMonster.jpg");
                message.Text = "Great!!... You killed the monster...Wanna Play Again?";
                loadBullet.Enabled = false;
                spinChambers.Enabled = false;
                fire.Enabled = false;
            }
            else if (player.chance == 0)                                    // For Game lose case check chance
            {                                                               // value to be 0.
                lose.Text = player.totalLoses + "";                           // Sets lose points on the lose label.
                message.Text = "You are dead... Click Play Again or close the window";
                loadBullet.Enabled = false;
                spinChambers.Enabled = false;
                fire.Enabled = false;
                soundPlayer.SoundLocation = @"Resource\mario_death.wav";
                soundPlayer.Play();
            }
            else                                                          // Remaining chance case where number of chance
            {                                                             // is still left for the player.
                soundPlayer.SoundLocation = @"Resource\GunBulletFire.wav";
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
            message.Text = "Welcome to the Game!!";
            pictureBox1.Image = Image.FromFile(@"Resource\Monster.jpg");
            loadBullet.Enabled = true;
            spinChambers.Enabled = false;
            playAgain.Enabled = false;
            fire.Enabled = false;
        }



    }
}
