using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireGame
{
    public class FireGameClass
    {
        int FireAwayChances = 2;
        int FireChances = 4;
        int Bullet = 0;
        bool Dead = false;
        bool Survived = false;

        public void LodLogic()
        {
            Bullet = 3;
        }

        public int Spinlogic()
        {
            Random rand = new Random();
            //giving the bullet a proper range
            Bullet = rand.Next(1, 7);
            return Bullet;

        }

        public int FireLogic()
        {
           
            if (Bullet == 1)
            {
                //if user will get 1 chance it will give the masseage user dead
                MessageBox.Show("you are dead");
                Dead = true;
            }
               //if the fire chance is greater than 1 then the following condition applies
               else if(FireChances > 1)

                
            {
                Bullet--;
                FireChances--;
                MessageBox.Show("Your chance is left carry on");
            }
            else
            {
                Bullet--;
                FireChances--;
            }

            return FireChances;
        }

        public int FireAwayLogic()
        {
            // if the fire away chance is equal to 1 then following condtion is applied
            if (Bullet == 1)
            {
                //In the fireaway button if user will get 1 chance he will survived
                MessageBox.Show("you survived");
                Survived = true;
            }
            else if(FireAwayChances > 1)
            {
                Bullet--;
                FireAwayChances--;
                MessageBox.Show("Your chance is left carry on");
            }
            else
            {
                Bullet--;
                FireAwayChances--;
            }
            return FireAwayChances;
        }

        public bool ReturnDead()
        {
            return Dead;
        }

        public bool ReturnSurvived()
        {
            return Survived;
        }
    }
}
