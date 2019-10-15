using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireGame
{
    class RoundButton : Button
    {
        //This method is used for creating a round button 
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath grapics = new GraphicsPath();
            grapics.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grapics);
            base.OnPaint(pevent);
        }
    }
}