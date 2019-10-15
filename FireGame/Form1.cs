using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace FireGame
{
    public partial class Form1 : Form
    {
        FireGameClass FClass = new FireGameClass();
        public Form1()
        {
            InitializeComponent();

        }
        //This method is used for loading the bullets
        private void LodBtn_Click(object sender, EventArgs e)
        {
            PicBox.Image = FireGame.Resource1.gunloading;
            SpinBtn.Enabled = true;
            FClass.LodLogic();
        }

        //This method is used for spinnig the revolver
        private void SpinBtn_Click(object sender, EventArgs e)
        {
            
            LodBtn.Enabled = false;
            PicBox.Image = FireGame.Resource1.spin1;
            AimBtn.Enabled = true;
            FClass.Spinlogic();
        }

        private void AimBtn_Click(object sender, EventArgs e)
        {
            SpinBtn.Enabled = false;
            PicBox.Image = FireGame.Resource1.aim;
            FreBtn.Enabled = true;
            FreAwy.Enabled = true;
        }

            //this method is used to fire the gun and generate the sound
        private void FreBtn_Click(object sender, EventArgs e)
        {
            AimBtn.Enabled = false;
            PicBox.Image = FireGame.Resource1.fire2;
            SoundPlayer sp = new SoundPlayer(FireGame.Resource1.Bulletsound);
            sp.Play();

           
            int chances = FClass.FireLogic();

            if (chances == 0)
            {
                FreAwy.Enabled = false;
                FreBtn.Enabled = false;
                //it will show the msg after play the game you survived
                MessageBox.Show("you survived");
            }
            
            bool dead = FClass.ReturnDead();
            if (dead == true)
            {
                FreAwy.Enabled = false;
                FreBtn.Enabled = false;
                //MessageBox.Show("you are dead");
            }
            
        }

        //This method is used for reload the game
        private void RelodBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        
        //This method is used for Fireaway
        private void FreAwy_Click(object sender, EventArgs e)
        {
            AimBtn.Enabled = false;
            int chances = FClass.FireAwayLogic();
                SoundPlayer sp = new SoundPlayer(FireGame.Resource1.Bulletsound);
                sp.Play();

            if (chances == 0)
            {

                FreAwy.Enabled = false;
                FreBtn.Enabled = false;
                //it will show the massage when the user will dead
                MessageBox.Show("you are dead");
            }

            bool survived = FClass.ReturnSurvived();
            if (survived == true)
            {
                FreAwy.Enabled = false;
                FreBtn.Enabled = false;
             
            }
        }    
    }
}
