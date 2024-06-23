using Audits;

namespace Laboratory_work__1
{
    public partial class MainWindow : Form
    {
        double[,] Data = new double[2, 3];
        bool[] Switches = { false, false, false, false, false, false, false };
        double[,] Result = new double[3, 3];
        int[,,] Coordinates = { // { start, on, off }
            { { 124, 135 },{ 105, 165 }, { 140, 162 } }, // Coordinates switch SA1
            { { 494, 135 },{ 510, 163 }, { 480, 164 } }, // Coordinates switch SA2
            { { 394, 135 },{ 394, 113 }, { 383, 113 } }, // Coordinates switch SA3
            { { 440, 228 },{ 440, 200 }, { 430, 200 } }, // Coordinates switch On/Off R3
            { { 300, 33 },{ 327, 33 }, { 325, 40 } }, // Coordinates switch On/Off R1
            { { 333, 367 },{ 305, 367 }, { 305, 377 } }, // Coordinates switch On/Off Left site shem
            { { 454, 367 },{ 483, 367 }, { 483, 377 } } // Coordinates switch On/Off Right site shem
        };
        int Range = 25;
        char Type;
        string TypeShem = String.Empty;

        Graphics? Graphic;
        Point Coordinates_Click;
        Audit Audit = new Audit();

        public MainWindow()
        {
            InitializeComponent();

            if (RadioButtonI.Checked || RadioButtonR.Checked)
            {
                PanelInputElement.Visible = true;
            }
            else
            {
                PanelInputElement.Visible = false;
            }
            PanelResult.Visible = false;
        }

        private void MainPicture_Paint(object sender, PaintEventArgs e)
        {
            Graphic = e.Graphics;
            if (Switches[0])
            { // Switch SA1
                Graphic.DrawLine(Pens.Black, Coordinates[0, 0, 0], Coordinates[0, 0, 1],
                    Coordinates[0, 1, 0], Coordinates[0, 1, 1]);
                if (Switches[5]) { TextBoxERS1.ReadOnly = false; } else { TextBoxERS1.ReadOnly = true; }
            }
            else
            {
                Graphic.DrawLine(Pens.Black, Coordinates[0, 0, 0], Coordinates[0, 0, 1],
                    Coordinates[0, 2, 0], Coordinates[0, 2, 1]);
                TextBoxERS1.ReadOnly = true;
            }
            if (Switches[1]) // Switch SA2
            {
                Graphic.DrawLine(Pens.Black, Coordinates[1, 0, 0], Coordinates[1, 0, 1],
                    Coordinates[1, 1, 0], Coordinates[1, 1, 1]);
                if (Switches[6]) { TextBoxERS2.ReadOnly = false; } else { TextBoxERS2.ReadOnly = true; }
            }
            else
            {
                Graphic.DrawLine(Pens.Black, Coordinates[1, 0, 0], Coordinates[1, 0, 1],
                    Coordinates[1, 2, 0], Coordinates[1, 2, 1]);
                TextBoxERS2.ReadOnly = true;
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
                TextBoxElement2.ReadOnly = false;
            }
            else
            {
                Graphic.DrawLine(Pens.Black, Coordinates[6, 0, 0], Coordinates[6, 0, 1],
                    Coordinates[6, 2, 0], Coordinates[6, 2, 1]);
                TextBoxElement2.ReadOnly = true;
            }

            if (Switches[2] && !Switches[3])
            {
                TextBoxElement3.ReadOnly = false;
            }
            else
            {
                TextBoxElement3.ReadOnly = true;
            }

            if (Switches[5] && !Switches[4])
            {
                TextBoxElement1.ReadOnly = false;
            }
            else
            {
                TextBoxElement1.ReadOnly = true;
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

        private void RadioButtonI_CheckedChanged(object sender, EventArgs e)
        {
            Type = 'i';
            PanelInputElement.Visible = true;
            if (RadioButtonI.Checked)
            {
                LabelElement.Text = "Струми:";
                LabelElement1.Text = "I1 = ";
                LabelElement2.Text = "I2 = ";
                LabelElement3.Text = "I3 = ";
                LabelElement4.Visible = true;
                TextBoxElement4.Visible = true;
                LabelResultElement1.Text = "R1 = ";
                LabelResultElement2.Text = "R2 = ";
                LabelResultElement3.Text = "R3 = ";
            }
        }

        private void RadioButtonR_CheckedChanged(object sender, EventArgs e)
        {
            Type = 'r';
            PanelInputElement.Visible = true;
            if (RadioButtonR.Checked)
            {
                LabelElement.Text = "Опори:";
                LabelElement1.Text = "R1 = ";
                LabelElement2.Text = "R2 = ";
                LabelElement3.Text = "R3 = ";
                LabelElement4.Visible = false;
                TextBoxElement4.Visible = false;
                LabelResultElement1.Text = "I1 = ";
                LabelResultElement2.Text = "I2 = ";
                LabelResultElement3.Text = "I3 = ";
            }
        }

        private void GetResult_Click(object sender, EventArgs e)
        {
            if (Type == 'i' || Type == 'r')
            {

                PanelResult.Visible = true;
                TextBox[] TextBoxesInput = { TextBoxERS1, TextBoxERS2, TextBoxElement1, TextBoxElement2, TextBoxElement3, TextBoxElement4 };
                TextBox[] TextBoxesResult = {TextBoxResultElement1, TextBoxResultElement2, TextBoxResultElement3,
                    TextBoxResultOm1, TextBoxResultOm2, TextBoxResultOm3};
                Label[] LabelResult = {LabelTextResult, LabelTextOm,LabelResultElement1, LabelResultElement2,
                    LabelResultElement3, LabelOm1, LabelOm2, LabelOm3};

                Data = Audit.CheckInput(TextBoxesInput, Type);

                TypeShem = Audit.CheckShem(Switches, Type);

                Result = Audit.GetResult(TypeShem, Data, Type);

                for (int i = 0; i < 3; i++)
                {
                    TextBoxesResult[i].Text = Convert.ToString(Result[0, i]);
                    TextBoxesResult[i + 3].Text = Convert.ToString(Result[1, i]);
                }
                if (Type == 'r' && TypeShem == "DefaultERS1R")
                {
                    TextBoxResultPw.Text = Convert.ToString(
                        Math.Round(
                            Math.Pow(Result[0, 0], 2) * (Data[1, 0] +
                            ((Data[1, 1] * Data[1, 2]) / (Data[1, 1] + Data[1, 2]))),
                            4, MidpointRounding.AwayFromZero));
                    TextBoxResultPw.Visible = true;
                    LabelPw.Visible = true;
                    // Pw = I1^2*(R1+((R2*R3)/(R2+R3))
                }
                else { TextBoxResultPw.Visible = false; LabelPw.Visible = false; }
                CheckVisibleShemResult(TypeShem, TextBoxesResult, LabelResult, Type);
            }
            else
            {
                MessageBox.Show("Ви не вибрали заданий елемент", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckVisibleShemResult(string TypeShem, TextBox[] TextBoxesResult, Label[] LabelResult, char Type)
        {
            if (TypeShem == "VariousSupportsR1" || TypeShem == "VariousSupportsR2" || TypeShem == "VariousSupportsR3" ||
                TypeShem == "VariousSupportsR1R2" || TypeShem == "VariousSupportsR1R3" || TypeShem == "VariousSupportsR2R3")
            {
                LabelResult[2].Text = "Pw = ";
                if (TypeShem == "VariousSupportsR1") { LabelResult[5].Text = "Ur1 = "; }
                else if (TypeShem == "VariousSupportsR2") { LabelResult[6].Text = "Ur2 = "; }
                else if (TypeShem == "VariousSupportsR3") { LabelResult[7].Text = "Ur3 = "; }
                else if (TypeShem == "VariousSupportsR1R2") { LabelResult[5].Text = "Ur1 = "; LabelResult[6].Text = "Ur2 = "; }
                else if (TypeShem == "VariousSupportsR1R3") { LabelResult[5].Text = "Ur1 = "; LabelResult[7].Text = "Ur3 = "; }
                else if (TypeShem == "VariousSupportsR2R3") { LabelResult[6].Text = "Ur2 = "; LabelResult[7].Text = "Ur3 = "; }
                OnOffVisibleResult(false, TextBoxesResult, LabelResult);
            }
            else if (TypeShem == "ShortCircuitUxx" || TypeShem == "ShortCircuitIkz")
            {
                LabelResult[0].Text = "Коротке замикання: ";
                LabelResult[1].Visible = false;
                if (TypeShem == "ShortCircuitUxx") { LabelResult[2].Text = "Uxx = "; }
                else if (TypeShem == "ShortCircuitIkz") { LabelResult[2].Text = "Ikz = "; }
                OnOffVisibleResult(false, TextBoxesResult, LabelResult);
            }
            else
            {
                if (Type == 'i') { RadioButtonI.Checked = false; RadioButtonI.Checked = true; }
                else if (Type == 'r') { RadioButtonR.Checked = false; RadioButtonR.Checked = true; }
                LabelResult[0].Text = "Результати розрахунку: ";
                LabelResult[1].Visible = true;
                OnOffVisibleResult(true, TextBoxesResult, LabelResult);
            }
        }

        private void OnOffVisibleResult(bool OnOff, TextBox[] TextBoxesResult, Label[] LabelResult)
        {
            for (int i = 0; i < 6; i++)
            {
                if (TextBoxesResult[i].Text == "0" && !OnOff)
                {
                    TextBoxesResult[i].Visible = false;
                    LabelResult[i + 2].Visible = false;
                }
                else { TextBoxesResult[i].Visible = true; LabelResult[i + 2].Visible = true; }
            }
        }

        private void тестовіЗапитанняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestWindow TestWindow = new TestWindow();
            TestWindow.Show();
        }

        private void лабораторнаРобота1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TheoryWindowFirstLab TheoryWindowFirstLab = new TheoryWindowFirstLab();
            TheoryWindowFirstLab.Show();
        }

        private void лабораторнаРобота2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TheoryWindowSecondLab TheoryWindowSecondLab = new TheoryWindowSecondLab();
            TheoryWindowSecondLab.Show();
        }

        private void лабораторнаРобота1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProcedureWindowFirstLab ProcedureWindowFirstLab = new ProcedureWindowFirstLab();
            ProcedureWindowFirstLab.Show();
        }

        private void лабораторнаРобота2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProcedureWindowSecondLab ProcedureWindowSecondLab = new ProcedureWindowSecondLab();
            ProcedureWindowSecondLab.Show();
        }

    }
}