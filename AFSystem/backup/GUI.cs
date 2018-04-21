using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Fuzzy;
using Bunifu.Framework;

namespace bunifu_ui_windows_defender
{
    public partial class GUI : Form
    {
        static Double BreakLevel;
        static Double distance;
        static Double speed;
        static Double angle;

        public void JNCK()
        {

            InitializeComponent();
            // INPUT

            // Kecepatan (0-120)
            FuzzySet fsLambat = new FuzzySet("Lambat", new TrapezoidalFunction(30, 50, TrapezoidalFunction.EdgeType.Right));
            FuzzySet fsSedang = new FuzzySet("Sedang", new TrapezoidalFunction(40, 60, 80));
            FuzzySet fsCepat = new FuzzySet("Cepat", new TrapezoidalFunction(70, 80, TrapezoidalFunction.EdgeType.Left));
            // Linguistik Kecepatan
            LinguisticVariable lvKecepatan = new LinguisticVariable("Kecepatan", 0, 120);
            lvKecepatan.AddLabel(fsLambat);
            lvKecepatan.AddLabel(fsSedang);
            lvKecepatan.AddLabel(fsCepat);

            // Jarak (0-10)
            FuzzySet fsDekat = new FuzzySet("Dekat", new TrapezoidalFunction(1, 2, TrapezoidalFunction.EdgeType.Right));
            FuzzySet fsJauh = new FuzzySet("Jauh", new TrapezoidalFunction(1, 4, 5));
            FuzzySet fsSangatJauh = new FuzzySet("SangatJauh", new TrapezoidalFunction(4, 7, TrapezoidalFunction.EdgeType.Left));
            // Linguistik Jarak
            LinguisticVariable lvJarak = new LinguisticVariable("Jarak", 0, 10);
            lvJarak.AddLabel(fsDekat);
            lvJarak.AddLabel(fsJauh);
            lvJarak.AddLabel(fsSangatJauh);

            // Kemiringan Jalan ((-90)-90)
            FuzzySet fsTurun = new FuzzySet("Turun", new TrapezoidalFunction(-40, -20, TrapezoidalFunction.EdgeType.Right));
            FuzzySet fsDatar = new FuzzySet("Datar", new TrapezoidalFunction(-25, 0, 25));
            FuzzySet fsNaik = new FuzzySet("Naik", new TrapezoidalFunction(20, 40, TrapezoidalFunction.EdgeType.Left));
            // Linguistik Kemiringan Jalan
            LinguisticVariable lvKemiringan = new LinguisticVariable("Kemiringan", -90, 90);
            lvKemiringan.AddLabel(fsTurun);
            lvKemiringan.AddLabel(fsDatar);
            lvKemiringan.AddLabel(fsNaik);

            // OUTPUT

            // Tingkat Pengereman (0-10)
            FuzzySet fsLemah = new FuzzySet("Lemah", new TrapezoidalFunction(3, 4, TrapezoidalFunction.EdgeType.Right));
            FuzzySet fsMedium = new FuzzySet("Sedang", new TrapezoidalFunction(3, 4, 6, 7));
            FuzzySet fsKuat = new FuzzySet("Kuat", new TrapezoidalFunction(6, 7, TrapezoidalFunction.EdgeType.Left));
            // Linguistik Kecepatan
            LinguisticVariable lvTingkatPengereman = new LinguisticVariable("TingkatPengereman", 0, 10);
            lvTingkatPengereman.AddLabel(fsLemah);
            lvTingkatPengereman.AddLabel(fsMedium);
            lvTingkatPengereman.AddLabel(fsKuat);

            // Database
            Database fuzzyDB = new Database();
            fuzzyDB.AddVariable(lvJarak);
            fuzzyDB.AddVariable(lvKemiringan);
            fuzzyDB.AddVariable(lvKecepatan);
            fuzzyDB.AddVariable(lvTingkatPengereman);

            // Inferensi System Engine
            InferenceSystem IS = new InferenceSystem(fuzzyDB, new CentroidDefuzzifier(1000));

            // Rules
            IS.NewRule("Rule 1", "IF Kecepatan IS Lambat AND Jarak IS Dekat AND Kemiringan IS Turun THEN TingkatPengereman IS Kuat");
            IS.NewRule("Rule 2", "IF Kecepatan IS Lambat AND Jarak IS Dekat AND Kemiringan IS Naik THEN TingkatPengereman IS Lemah");
            IS.NewRule("Rule 3", "IF Kecepatan IS Lambat AND Jarak IS Dekat AND Kemiringan IS Datar THEN TingkatPengereman IS Sedang");
            IS.NewRule("Rule 4", "IF Kecepatan IS Lambat AND Jarak IS Jauh AND Kemiringan IS Datar THEN TingkatPengereman IS Lemah");
            IS.NewRule("Rule 5", "IF Kecepatan IS Lambat AND Jarak IS Jauh AND Kemiringan IS Naik THEN TingkatPengereman IS Lemah");
            IS.NewRule("Rule 6", "IF Kecepatan IS Lambat AND Jarak IS Jauh AND Kemiringan IS Turun THEN TingkatPengereman IS Sedang");
            IS.NewRule("Rule 7", "IF Kecepatan IS Lambat AND Jarak IS SangatJauh AND Kemiringan IS Datar THEN TingkatPengereman IS Lemah");
            IS.NewRule("Rule 8", "IF Kecepatan IS Lambat AND Jarak IS SangatJauh AND Kemiringan IS Naik THEN TingkatPengereman IS Lemah");
            IS.NewRule("Rule 9", "IF Kecepatan IS Lambat AND Jarak IS SangatJauh AND Kemiringan IS Turun THEN TingkatPengereman IS Sedang");
            IS.NewRule("Rule 10", "IF Kecepatan IS Sedang AND Jarak IS Dekat AND Kemiringan IS Datar THEN TingkatPengereman IS Kuat");
            IS.NewRule("Rule 11", "IF Kecepatan IS Sedang AND Jarak IS Dekat AND Kemiringan IS Naik THEN TingkatPengereman IS Sedang");
            IS.NewRule("Rule 12", "IF Kecepatan IS Sedang AND Jarak IS Dekat AND Kemiringan IS Turun THEN TingkatPengereman IS Kuat");
            IS.NewRule("Rule 13", "IF Kecepatan IS Sedang AND Jarak IS Jauh AND Kemiringan IS Datar THEN TingkatPengereman IS Sedang");
            IS.NewRule("Rule 14", "IF Kecepatan IS Sedang AND Jarak IS Jauh AND Kemiringan IS Naik THEN TingkatPengereman IS Lemah");
            IS.NewRule("Rule 15", "IF Kecepatan IS Sedang AND Jarak IS Jauh AND Kemiringan IS Turun THEN TingkatPengereman IS Kuat");
            IS.NewRule("Rule 16", "IF Kecepatan IS Sedang AND Jarak IS SangatJauh AND Kemiringan IS Datar THEN TingkatPengereman IS Lemah");
            IS.NewRule("Rule 17", "IF Kecepatan IS Sedang AND Jarak IS SangatJauh AND Kemiringan IS Naik THEN TingkatPengereman IS Lemah");
            IS.NewRule("Rule 18", "IF Kecepatan IS Sedang AND Jarak IS SangatJauh AND Kemiringan IS Turun THEN TingkatPengereman IS Sedang");
            IS.NewRule("Rule 19", "IF Kecepatan IS Cepat AND Jarak IS Dekat AND Kemiringan IS Datar THEN TingkatPengereman IS Kuat");
            IS.NewRule("Rule 20", "IF Kecepatan IS Cepat AND Jarak IS Dekat AND Kemiringan IS Naik THEN TingkatPengereman IS Sedang");
            IS.NewRule("Rule 21", "IF Kecepatan IS Cepat AND Jarak IS Dekat AND Kemiringan IS Turun THEN TingkatPengereman IS Kuat");
            IS.NewRule("Rule 22", "IF Kecepatan IS Cepat AND Jarak IS Jauh AND Kemiringan IS Datar THEN TingkatPengereman IS Kuat");
            IS.NewRule("Rule 23", "IF Kecepatan IS Cepat AND Jarak IS Jauh AND Kemiringan IS Naik THEN TingkatPengereman IS Sedang");
            IS.NewRule("Rule 24", "IF Kecepatan IS Cepat AND Jarak IS Jauh AND Kemiringan IS Turun THEN TingkatPengereman IS Kuat");
            IS.NewRule("Rule 25", "IF Kecepatan IS Cepat AND Jarak IS SangatJauh AND Kemiringan IS Datar THEN TingkatPengereman IS Sedang");
            IS.NewRule("Rule 26", "IF Kecepatan IS Cepat AND Jarak IS SangatJauh AND Kemiringan IS Naik THEN TingkatPengereman IS Lemah");
            IS.NewRule("Rule 27", "IF Kecepatan IS Cepat AND Jarak IS SangatJauh AND Kemiringan IS Turun THEN TingkatPengereman IS Kuat");
            
            // Set Input
            IS.SetInput("Kecepatan", (float)speed);
            IS.SetInput("Jarak", (float)distance);
            IS.SetInput("Kemiringan", (float)angle);
                
            // Get output
            double BreakLevel = IS.Evaluate("TingkatPengereman");
            // Tampilkan Hasil
            System.Console.WriteLine(BreakLevel);
        }


        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            indicator.Top = ((ns1.BunifuImageButton)sender).Top - 10;
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }


        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void TB_Speed_ValueChanged(object sender, EventArgs e)
        {
            double speed = TB_Speed.Value;
            Gauge_Speed.Value = Convert.ToInt32(speed * 0.833333);
            Value_Speed.Text = Convert.ToString(speed) + " Km/h";
            JNCK();

        }

        private void bunifuGauge1_Load(object sender, EventArgs e)
        {

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
                double value_min = TB_AngleMin.Value * -1;
                Value_AngleMin.Text = Convert.ToString(Math.Ceiling(value_min) + "°");

            }
            JNCK();
        }

        private void TB_Distance_ValueChanged(object sender, EventArgs e)
        {
            double angle = TB_Distance.Value;
            Gauge_Distance.Value = Convert.ToInt32(angle) * 10;
            Value_Distance.Text = Convert.ToString(Math.Ceiling(angle) + " m");
            JNCK();
        }

        private void TB_AnglePlus_ValueChanged(object sender, EventArgs e)
        {
            if (TB_AngleMin.Value != 0)
            {
                TB_AnglePlus.Value = 0;
            }
            else
            {
                double angle = TB_AnglePlus.Value * 1.1111111;
                Gauge_Angle.Value = Convert.ToInt32(angle);

                Value_AnglePlus.Text = TB_AnglePlus.Value + "°";
            }
            JNCK();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Gauge_Break_Load(object sender, EventArgs e)
        {
            
            Gauge_Break.Value = Convert.ToInt32(BreakLevel);

        }
        /*
        public int REMBANG(object sender, EventArgs e)
        {


            return Convert.ToInt32(BreakLevel);

        }*/
    }
}

