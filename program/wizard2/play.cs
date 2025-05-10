using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wizard2
{
    public partial class play : Form
    {
        public play()
        {
            InitializeComponent();
        }
        public static int Wisdom; // declare public static to each of these variable
        public static int Wisdom2;
        public static int Health;
        public static int Health2;
        public static int Dexterity;
        public static int Dexterity2;
        public static int MaxHealth1;
        public static int MaxHealth2;
        public static int Element;
        public static double Attack;
        public static double Attack2;
        public static double DblHealth;
        public static double DblHealth2;
        public static bool P1Wins;
        public static bool P2Wins;

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void play_Load(object sender, EventArgs e) 
        {
            label9.Text = Form1.StrName; //show the name inputted on the the second interface on label 9
            label10.Text = Form1.StrElement; //show element chosen on the first form to the second form on label 10

            Random rnd = new Random(); // random variable are given to each
            Wisdom = rnd.Next(15, 50); // cpu chooses a random number between 15 and 50 for wisdom for the first player
            Dexterity = rnd.Next(15, 50); // cpu chooses a random number between 15 and 50 for dexterity the first player
            Wisdom2 = rnd.Next(15, 50); // cpu chooses a random number between 15 and 50 for wisdom for the second player
            Dexterity2 = rnd.Next(15, 50); // cpu chooses a random number between 15 and 50 for dexterity for the second player
            Health = rnd.Next(100, 150); // cpu chooses a random number between 100 and 150 for health for the first player
            Health2 = rnd.Next(100, 150); // cpu chooses a random number between 100 and 150 for health for the second player

            label18.Text = Health.ToString(); // label 18 is where the health is being outputted for the 1st player
            label17.Text = Health2.ToString(); // label 17 is where the health is being outputted for the 2nd player

            label11.Text = Wisdom.ToString(); // label 11 is where the wisdom is being outputted for the 1st player
            label12.Text = Dexterity.ToString(); // label 12 is where the dexterity is being outputted for the 1st player

            label14.Text = Wisdom2.ToString(); // label 14 is where the wisdom is being outputted for the 2nd player
            label15.Text = Dexterity2.ToString(); // label 15 is where the dexterity is being outputted for the 2nd player

            Element = rnd.Next(1, 5); // random numbers for the elements between 1 and 5
            if (Element == 1) { label16.Text = "Air"; } // gives a number for element, air is ouputted on label 16 for 2nd wizard
            if (Element == 2) { label16.Text = "Water"; } // gives a number for element, water is ouputted on label 16 for 2nd wizard
            if (Element == 3) { label16.Text = "Earth"; } // gives a number for element, earth is ouputted on label 16 for second wizard
            if (Element == 4) { label16.Text = "Fire"; } // gives a number for element, fire is ouputted on label 16 for 2nd wizard

            MaxHealth1 = Health; //gives max health for the current health
            MaxHealth2 = Health2; //gives max health for the current health

            progressBar1.Maximum = MaxHealth1; // max health for the first progress bar
            progressBar1.Value = Health; // gives a value to the current health
            progressBar2.Maximum = MaxHealth2; // max health fot the second progress bar
            progressBar2.Value = Health2; // gives a value to the current health

            DblHealth = Health; // double health to the current health when a wizard attacks
            DblHealth2 = Health2; // double health to the current health when a wizard attacks
            P1Wins = false; // wins for the 1st player
            P2Wins = false; // wins for the 2nd player
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        public void Fight1()
        {
            Attack = (Wisdom2); // the damage after each attack
            if ((Form1.StrElement == ("Air")) && (Element == 3)) // first wizard will attack the second one
            { Attack = Attack * 1.5; } // air will damage element 3 (earth) by 50%
            if ((Form1.StrElement == ("Water")) && (Element == 4)) // first wizard will attack the second one
            { Attack = Attack * 1.5; } // water will damage element 4 (fire) by 50%
            if ((Form1.StrElement == ("Earth")) && (Element == 2)) // first wizard will attack the second one
            { Attack = Attack * 1.5; } // earth will damage element 2 (water) by 50%
            if ((Form1.StrElement == ("Fire")) && (Element == 1)) // first wizard will attack the second one
            { Attack = Attack * 1.5; } // fire will damage element 1 (air) by 50%
            
            DblHealth = (DblHealth - Attack2); // health decrease after each attack
            Math.Ceiling(DblHealth); // does the maths for the dblhealth
            Health = Convert.ToInt32(DblHealth); // converts the value to an int 
            label18.Text = DblHealth.ToString(); // damage is then outputted on label 18
        }

        public void Fight2()
        {
            Attack2 = (Wisdom2); // damage after each attack
            if ((Element == 3) && (Form1.StrElement == ("Air"))) // second wizard attacks the first wizard
            { Attack2 = Attack2 * 1.5; } // damages the wizard by 50%
            if ((Element == 4) && (Form1.StrElement == ("Water"))) // second wizard attacks the first wizard
            { Attack2 = Attack2 * 1.5; } // damages the wizard by 50%
            if ((Element == 2) && (Form1.StrElement == ("Earth"))) // second wizard attacks the first wizard
            { Attack2 = Attack2 * 1.5; } // damages the wizard by 50%
            if ((Element == 1) && (Form1.StrElement == ("Fire"))) // second wizard attacks the first wizard
            { Attack2 = Attack2 * 1.5; } // damages the wizard by 50%

            DblHealth2 = (DblHealth2 - Attack); // health decrease after each attack
            Math.Ceiling(DblHealth2); // does the maths for the dblhealth
            Health2 = Convert.ToInt32(DblHealth2); // converts the value to an int 
            label17.Text = DblHealth2.ToString(); // damage is being outputted on label 17
        }

        private void btnFight_Click(object sender, EventArgs e)
        {

            if (Dexterity > Dexterity2) // if the first user has the highest dexterity, they attack first
            {
                if ((P1Wins == true) || (P2Wins == true))
                { }
                else if ((P1Wins == false) && (P2Wins == false))
                {
                    if ((Health <= 0) && (Health2 > Health)) 
                    { MessageBox.Show("Evil Wizard won!"); P2Wins = true; } //shows the message box if health is <=0
                    else if ((Health2 <= 0) && (Health > Health2)) 
                    { MessageBox.Show("You won!"); P1Wins = true; } //shows the message box if health is <=0
                    if ((Health > 0) && (Health2 > 0)) 
                    { Fight1(); }
                }
                if ((P1Wins == true) || (P2Wins == true))
                { }
                else if ((P1Wins == false) && (P2Wins == false))
                {
                    if ((Health > 0) && (Health2 > 0)) 
                    { Fight2(); }
                    if ((Health <= 0) && (Health2 > Health)) 
                    { MessageBox.Show("Evil Wizard won!"); P2Wins = true; } //shows the message box if health is <=0
                    else if ((Health2 <= 0) && (Health > Health2)) 
                    { MessageBox.Show("You won!"); P1Wins = true; } //shows the message box if health is <=0
                }
            }
            else if (Dexterity2 > Dexterity)
            {
                if ((P1Wins == true) || (P2Wins == true))
                { }
                else if ((P1Wins == false) && (P2Wins == false))
                {
                    if ((Health <= 0) && (Health2 > Health)) 
                    { MessageBox.Show("Evil Wizard won!"); P2Wins = true; } //shows the message box if health is <=0
                    else if ((Health2 <= 0) && (Health > Health2)) 
                    { MessageBox.Show("You won!"); P1Wins = true; } //shows the message box if health is <=0
                    if ((Health > 0) && (Health2 > 0)) 
                    { Fight2(); }
                }
                if ((P1Wins == true) || (P2Wins == true))
                { }
                else if ((P1Wins == false) && (P2Wins == false))
                {
                    if ((Health <= 0) && (Health2 > Health)) 
                    { MessageBox.Show("Evil Wizard won!"); P2Wins = true; } //shows the message box if health is <=0
                    else if ((Health2 <= 0) && (Health > Health2)) 
                    { MessageBox.Show("You won!"); P1Wins = true; } //shows the message box if health is <=0
                    if ((Health > 0) && (Health2 > 0)) 
                    { Fight1(); }
                }
            }
            

            if (Health < 0) { Health = 0; } //if the health of a wizard is <0, means that the other wizard won
            if (Health2 < 0) { Health2 = 0; }

            progressBar1.Maximum = MaxHealth1; // maximum health given on the first progress bar
            progressBar1.Value = Health;  // value given on the first progress bar
            progressBar2.Maximum = MaxHealth2;  // maximum health given on the second progress bar
            progressBar2.Value = Health2;  // value given on the second progress bar
        }
        private void win_Click(object sender, EventArgs e)
        {

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            this.Hide();
            play form = new play();
            form.Show(); // refreshes the whole page when the user presses the button so they can play again
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
