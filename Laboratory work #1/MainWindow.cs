namespace Laboratory_work__1
{
    public partial class MainWindow : Form
    {
        double[,] Data = new double[2, 3];
        bool[] Switches = { false, false, false, false, false, false, false };
        double[,] Result = new double[3, 3];
        int[,,] Coordinates = { // { start, on, off }
            { { 128, 130 },{ 110, 157 }, { 140, 157 } }, // Coordinates switch SA1
            { { 500, 130 },{ 520, 157 }, { 490, 157 } }, // Coordinates switch SA2
            { { 330, 108 },{ 330, 130 }, { 340, 130 } }, // Coordinates switch SA3
            { { 376, 225 },{ 376, 195 }, { 365, 195 } }, // Coordinates switch On/Off R3
            { { 208, 28 },{ 235, 28 }, { 235, 18 } }, // Coordinates switch On/Off R1
            { { 210, 364 },{ 180, 364 }, { 180, 354 } }, // Coordinates switch On/Off Left site shem
            { { 422, 364 },{ 455, 364 }, { 455, 354 } } // Coordinates switch On/Off Right site shem
        };
        int Range = 25;

        Graphics Graphic;
        Point Coordinates_Click;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainPicture_Paint(object sender, PaintEventArgs e)
        {
            Graphic = e.Graphics;
            if (Switches[0])
            { // Switch SA1
                Graphic.DrawLine(Pens.Black, Coordinates[0, 0, 0], Coordinates[0, 0, 1],
                    Coordinates[0, 1, 0], Coordinates[0, 1, 1]);
            }
            else
            {
                Graphic.DrawLine(Pens.Black, Coordinates[0, 0, 0], Coordinates[0, 0, 0],
                    Coordinates[0, 2, 0], Coordinates[0, 2, 1]);
            }
            if (Switches[1]) // Switch SA2
            {
                Graphic.DrawLine(Pens.Black, Coordinates[1, 0, 0], Coordinates[1, 0, 1],
                    Coordinates[1, 1, 0], Coordinates[1, 1, 1]);
            }
            else
            {
                Graphic.DrawLine(Pens.Black, Coordinates[1, 0, 0], Coordinates[1, 0, 1],
                    Coordinates[1, 2, 0], Coordinates[1, 2, 1]);
            }
            if (Switches[2]) // Switch SA3
            {
                Graphic.DrawLine(Pens.Black, Coordinates[2, 0, 0], Coordinates[2, 0, 1],
                    Coordinates[2, 1, 0], Coordinates[2, 1, 1]);
            }
            else
            {
                Graphic.DrawLine(Pens.Black, Coordinates[2, 0, 0], Coordinates[2, 0, 1],
                    Coordinates[2, 2, 0], Coordinates[2, 2, 1]);
            }
            if (Switches[3]) // Switch On/Off R3
            {
                Graphic.DrawLine(Pens.Black, Coordinates[3, 0, 0], Coordinates[3, 0, 1],
                    Coordinates[3, 1, 0], Coordinates[3, 1, 1]);
            }
            else
            {
                Graphic.DrawLine(Pens.Black, Coordinates[3, 0, 0], Coordinates[3, 0, 1],
                    Coordinates[3, 2, 0], Coordinates[3, 2, 1]);
            }
            if (Switches[4]) // Switch On/Off R1
            {
                Graphic.DrawLine(Pens.Black, Coordinates[4, 0, 0], Coordinates[4, 0, 1],
                    Coordinates[4, 1, 0], Coordinates[4, 1, 1]);
            }
            else
            {
                Graphic.DrawLine(Pens.Black, Coordinates[4, 0, 0], Coordinates[4, 0, 1],
                    Coordinates[4, 2, 0], Coordinates[4, 2, 1]);
            }
            if (Switches[5]) // Switch On/Off Left site shem
            {
                Graphic.DrawLine(Pens.Black, Coordinates[5, 0, 0], Coordinates[5, 0, 1],
                    Coordinates[5, 1, 0], Coordinates[5, 1, 1]);
            }
            else
            {
                Graphic.DrawLine(Pens.Black, Coordinates[5, 0, 0], Coordinates[5, 0, 1],
                    Coordinates[5, 2, 0], Coordinates[5, 2, 1]);
            }
            if (Switches[6]) // Switch On/Off Right site shem
            {
                Graphic.DrawLine(Pens.Black, Coordinates[6, 0, 0], Coordinates[6, 0, 1],
                    Coordinates[6, 1, 0], Coordinates[6, 1, 1]);
            }
            else
            {
                Graphic.DrawLine(Pens.Black, Coordinates[6, 0, 0], Coordinates[6, 0, 1],
                    Coordinates[6, 2, 0], Coordinates[6, 2, 1]);
            }
        }

        private void MainPicture_MouseClick(object sender, MouseEventArgs e)
        {
            Coordinates_Click = e.Location;

            for (int i = 0; i <= 6; i++)
            {
                int MidleX = (Coordinates[i, 0, 0] + Coordinates[i, 1, 0] + Coordinates[i, 2, 0]) / 3;
                int MidleY = (Coordinates[i, 0, 1] + Coordinates[i, 1, 1] + Coordinates[i, 2, 1]) / 3;
                if (Coordinates_Click.X < MidleX + Range && Coordinates_Click.X > MidleX - Range &&
                    Coordinates_Click.Y < MidleY + Range && Coordinates_Click.Y > MidleY - Range)
                {
                    Switches[i] = !Switches[i];
                }
            }
            this.Refresh();
        }
    }
}