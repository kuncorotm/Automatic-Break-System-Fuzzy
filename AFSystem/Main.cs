using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework;


namespace AFSystem
{

    public partial class Main : Form
    {
        Double BrakeLevel = 0;
        Double distance = 0;
        Double speed = 0;
        Double angleMin = 0;
        Double anglePlus = 0;
        FuzzyEngine Engine = new FuzzyEngine();


        public Main()
        {

            InitializeComponent();

        }

        public void Fuzzy()
        {
            FuzzyEngine FE = new FuzzyEngine();
            if (TB_AngleMin.Value == 0)
            {
                FE.Speed(TB_Speed.Value);
                FE.Distance(TB_Distance.Value);
                FE.Angle(TB_AnglePlus.Value);
                
                FE.Rules();
                FE.Centroid(10);
                lblCOG.Text = "COG Brake : " + FE.Crisp;
                Gauge_Break.Value = (int)FE.Crisp * 10;
                lblvalueBrake.Text = Convert.ToString(Math.Ceiling(FE.Crisp));
            }
            else
            {
                FE.Speed(TB_Speed.Value);
                FE.Distance(TB_Distance.Value);
                FE.Angle(TB_AngleMin.Value*(-1));
               
                FE.Rules();
                FE.Centroid(10);
                lblCOG.Text = "COG Brake : " + FE.Crisp;
                Gauge_Break.Value = (int)FE.Crisp * 10;
                lblvalueBrake.Text = Convert.ToString(Math.Ceiling(FE.Crisp));
            }
        }
        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void TB_Speed_ValueChanged(object sender, EventArgs e)
        {
            double speed = TB_Speed.Value;
            Gauge_Speed.Value = Convert.ToInt32(speed * 0.833333);
            lblvalueSpeed.Text = Convert.ToString(speed) + " Km/h";
        }

        private void TB_AngleMin_ValueChanged(object sender, EventArgs e)
        {
            if (TB_AnglePlus.Value != 0)
            {
                TB_AngleMin.Value = 0;
            }
            else
            {
                double distance = TB_AngleMin.Value * 1.1111111;
                Gauge_Angle.Value = Convert.ToInt32(distance);
                angleMin = TB_AngleMin.Value * -1;
                lblvalueAngle.Text = Convert.ToString(Math.Ceiling(angleMin) + "°");
            }

        }

        private void TB_Distance_ValueChanged(object sender, EventArgs e)
        {
            double distance = TB_Distance.Value;
            Gauge_Distance.Value = Convert.ToInt32(distance) * 10;
            lblvalueDistance.Text = Convert.ToString(Math.Ceiling(distance) + " m");

        }

        private void TB_AnglePlus_ValueChanged(object sender, EventArgs e)
        {
            if (TB_AngleMin.Value != 0)
            {
                TB_AnglePlus.Value = 0;
            }
            else
            {
                anglePlus = TB_AnglePlus.Value * 1.1111111;
                Gauge_Angle.Value = Convert.ToInt32(anglePlus);

                lblvalueAngle.Text = TB_AnglePlus.Value + "°";
            }

        }

        private void bunifuImageButton9_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            Fuzzy();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton6_Click_1(object sender, EventArgs e)
        {
            bool IsOpen = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
            {
                if (f.Name == "FuzzyExplain")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                Manual form = new Manual();
                form.Show();
            }

        }
    }
}

