namespace Laboratory_work__1
{
    public partial class MainWindow : Form
    {
        double[,] Data = new double[2, 3];
        bool[] Switches = { false, false, false, false, false, false, false };
        double[,] Result = new double[3, 3];

        Graphics Graphic;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainPicture_Paint(object sender, PaintEventArgs e)
        {
            Graphic = e.Graphics;
            if (Switches[0]) { // Switch SA1
                Graphic.DrawLine(Pens.Black, 128, 130, 110, 157);
            } else
            {
                Graphic.DrawLine(Pens.Black, 128, 130, 140, 157);
            }
            if (Switches[1]) // Switch SA2
            {
                Graphic.DrawLine(Pens.Black, 500, 130, 520, 157);
            } else
            {
                Graphic.DrawLine(Pens.Black, 500, 130, 490, 157);
            }
            if (Switches[2]) // Switch SA3
            {
                Graphic.DrawLine(Pens.Black, 330, 108, 330, 130);
            } else
            {
                Graphic.DrawLine(Pens.Black, 330, 108, 340, 130);
            }
            if (Switches[3]) // Switch On/Off R3
            {
                Graphic.DrawLine(Pens.Black, 376, 225, 376, 195);
            } else
            {
                Graphic.DrawLine(Pens.Black, 376, 225, 365, 195);
            }
            if (Switches[4]) // Switch On/Off R1
            {
                Graphic.DrawLine(Pens.Black, 208, 28, 235, 28);
            } else
            {
                Graphic.DrawLine(Pens.Black, 208, 28, 235, 18);
            }
            if (Switches[5]) // Switch On/Off Left site shem
            {
                Graphic.DrawLine(Pens.Black, 180, 364, 210, 364);
            } else
            {
                Graphic.DrawLine(Pens.Black, 180, 364, 210, 354);
            }
            if (Switches[6]) // Switch On/Off Right site shem
            {
                Graphic.DrawLine(Pens.Black, 422, 364, 450, 364);
            } else
            {
                Graphic.DrawLine(Pens.Black, 422, 364, 450, 354);
            }
        }
    }
}