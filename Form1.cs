using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace NoiseGate
{
    public partial class MainWindow : Form
    {
        public double CurValue, OldValue;
        public double CurFValue = 0, OldFValue = 0;
        public double CurDValue = 0, OldDValue = 0;
        public double CurDelta = 1.0, OldDelta = 1.0;
        Random a = new Random();
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            SensorType.Text = "4-20 мА";
            NoiseShaper.RunWorkerAsync();
        }

        private void SensorType_TextChanged(object sender, EventArgs e)
        {
            switch (SensorType.Text)
            {
                case "0-5 мА":
                    SensorValue.Minimum = 0.0M;
                    SensorValue.Maximum = 5.0M;
		    SensorValue.Value = 2.5M; OldValue = 2.5;
                    CurFValue = 2.5; OldFValue = 2.5;
                    CurDValue = 2.5; OldDValue = 2.5;
                    break;
                case "0-20 мА":
                    SensorValue.Minimum = 0.0M;
                    SensorValue.Maximum = 20.0M;
		    SensorValue.Value = 10.0M; OldValue = 10;
                    CurFValue = 10; OldFValue = 10;
                    CurDValue = 10; OldDValue = 10;
                    break;
                case "4-20 мА":
                    SensorValue.Minimum = 4.0M;
                    SensorValue.Maximum = 20.0M;
		    SensorValue.Value = 12.0M; OldValue = 12;
                    CurFValue = 12; OldFValue = 12;
                    CurDValue = 12; OldDValue = 12;
                    break;
            }
        }

        public void NoiseShaper_DoWork(object sender, DoWorkEventArgs e)
        {
            for (; ; )
            {
                this.MakeCalc();
                Thread.Sleep(200);
            }
        }

        public void MakeCalc()
        {
            CurValue = (double)SensorValue.Value + (a.NextDouble() - 0.5) * (double)NoiseLevel.Value;
	        CurDelta = (OldDelta * ((double)FilterAmount.Value - 1) + CurValue - OldValue) / (double)FilterAmount.Value;
//	        if (Math.Abs(CurValue - OldValue) > CurDelta) CurFValue = OldFValue + CurDelta * Math.Sign(CurValue - OldValue) / (double)FilterAmount.Value;
//          else CurFValue = CurValue;
	        CurFValue = OldFValue + CurDelta / (double)KDelta.Value;
            OldFValue = CurFValue; OldDelta = CurDelta;
            InputSignal.Text = CurValue.ToString("F");
            FilteredSignal.Text = CurFValue.ToString("F");
//          DeltaSignal.Text = CurDValue.ToString("F");
            DeltaText.Text = CurDelta.ToString("F4");
        }

        private void SensorType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
