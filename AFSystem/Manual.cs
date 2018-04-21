using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AFSystem
{
    public partial class Manual : Form
    {
        const int AW_SLIDE = 0X40000;
        const int AW_HOR_POSITIVE = 0X1;
        const int AW_HOR_NEGATIVE = 0X2;
        const int AW_BLEND = 0X80000;
        Main main = new Main();
        


        [DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);
        public Manual()
        {
            InitializeComponent();

        }

      
        public void Fuzzy()
        {
            FuzzyEngine FE = new FuzzyEngine();
            {
                FE.Speed((float)Convert.ToDouble(bunifuMetroTextbox1.Text));
                FE.Distance((float)Convert.ToDouble(bunifuMetroTextbox2.Text));
                FE.Angle((float)Convert.ToDouble(bunifuMetroTextbox3.Text));

                lblSpeedSlow.Text = "Slow : " + Convert.ToString((Math.Round(FE.mfSpeedSlow,2)));
                lblSpeedMedium.Text = "Med : " + Convert.ToString((Math.Round(FE.mfSpeedMedium,2)));
                lblSpeedFast.Text = "Fast : " + Convert.ToString((Math.Round(FE.mfSpeedFast,2)));

                lblDistanceNear.Text = "Near : " + Convert.ToString((Math.Round(FE.mfDistanceNear,2)));
                lblDistanceFar.Text = "Far : " + Convert.ToString((Math.Round(FE.mfDistanceFar,2)));
                lblDistanceTooFar.Text = "T.Far : " + Convert.ToString((Math.Round(FE.mfDistanceTooFar,2)));

                lblAngleDown.Text = "Down : " + Convert.ToString((Math.Round(FE.mfAngleDown,2)));
                lblAngleFlat.Text = "Flat : " + Convert.ToString((Math.Round(FE.mfAngleFlat,2)));
                lblAngleUp.Text = "Up : " + Convert.ToString((Math.Round(FE.mfAngleUp,2)));
                FE.MemberFunction();
                FE.Rules();
                FE.Centroid(10);
                lblCOG.Text = "COG Brake : "+Convert.ToString(FE.Crisp);
                lblBrakeWeak.Text = "Weak : " + Math.Round(FE.BrakeWeak,2);
                lblBrakeMed.Text = "Med : " + Math.Round(FE.BrakeMedium,2);
                lblBrakeStrong.Text = "Strong : " + Math.Round(FE.BrakeStrong,2);
                bunifuProgressBar1.Value = (int)FE.Crisp;
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            //Load the Form At Position of Main Form
            int WidthOfMain = Application.OpenForms["Main"].Width;
            int HeightofMain = Application.OpenForms["Main"].Height;
            int LocationMainX = Application.OpenForms["Main"].Location.X;
            int locationMainy = Application.OpenForms["Main"].Location.Y;

            //Set the Location
            this.Location = new Point(LocationMainX + WidthOfMain, locationMainy);

            //Animate form
            AnimateWindow(this.Handle, 300, AW_SLIDE | AW_HOR_POSITIVE);
        }
        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Fuzzy();
        }

        private void lblLogoText_Click(object sender, EventArgs e)
        {

        }
    }
}
