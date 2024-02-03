namespace Laboratory_work__1
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainPicture = new PictureBox();
            LabelElementERS = new Label();
            LabelERS1 = new Label();
            TextBoxERS1 = new TextBox();
            TextBoxERS2 = new TextBox();
            LabelERS2 = new Label();
            LabelDano = new Label();
            RadioButtonI = new RadioButton();
            RadioButtonR = new RadioButton();
            LabelElement = new Label();
            LabelElement1 = new Label();
            TextBoxElement1 = new TextBox();
            LabelElement2 = new Label();
            TextBoxElement2 = new TextBox();
            LabelElement3 = new Label();
            TextBoxElement3 = new TextBox();
            GetResult = new Button();
            PanelResult = new Panel();
            TextBoxResultOm3 = new TextBox();
            LabelOm3 = new Label();
            TextBoxResultOm2 = new TextBox();
            LabelOm2 = new Label();
            TextBoxResultOm1 = new TextBox();
            LabelOm1 = new Label();
            LabelTextOm = new Label();
            TextBoxResultElement3 = new TextBox();
            LabelResultElement3 = new Label();
            TextBoxResultElement2 = new TextBox();
            LabelResultElement2 = new Label();
            TextBoxResultElement1 = new TextBox();
            LabelResultElement1 = new Label();
            LabelTextResult = new Label();
            PanelInputElement = new Panel();
            ((System.ComponentModel.ISupportInitialize)MainPicture).BeginInit();
            PanelResult.SuspendLayout();
            PanelInputElement.SuspendLayout();
            SuspendLayout();
            // 
            // MainPicture
            // 
            MainPicture.Image = Properties.Resources.main_picture_shem;
            MainPicture.Location = new Point(32, 12);
            MainPicture.Name = "MainPicture";
            MainPicture.Size = new Size(657, 380);
            MainPicture.SizeMode = PictureBoxSizeMode.AutoSize;
            MainPicture.TabIndex = 0;
            MainPicture.TabStop = false;
            MainPicture.Paint += MainPicture_Paint;
            MainPicture.MouseClick += MainPicture_MouseClick;
            // 
            // LabelElementERS
            // 
            LabelElementERS.AutoSize = true;
            LabelElementERS.Location = new Point(730, 30);
            LabelElementERS.Name = "LabelElementERS";
            LabelElementERS.RightToLeft = RightToLeft.No;
            LabelElementERS.Size = new Size(162, 15);
            LabelElementERS.TabIndex = 1;
            LabelElementERS.Text = "Електрорушійна сила (ЕРС):";
            // 
            // LabelERS1
            // 
            LabelERS1.AutoSize = true;
            LabelERS1.Location = new Point(750, 70);
            LabelERS1.Name = "LabelERS1";
            LabelERS1.Size = new Size(33, 15);
            LabelERS1.TabIndex = 2;
            LabelERS1.Text = "E1 = ";
            // 
            // TextBoxERS1
            // 
            TextBoxERS1.Location = new Point(785, 67);
            TextBoxERS1.Name = "TextBoxERS1";
            TextBoxERS1.Size = new Size(100, 23);
            TextBoxERS1.TabIndex = 3;
            // 
            // TextBoxERS2
            // 
            TextBoxERS2.Location = new Point(785, 112);
            TextBoxERS2.Name = "TextBoxERS2";
            TextBoxERS2.Size = new Size(100, 23);
            TextBoxERS2.TabIndex = 5;
            // 
            // LabelERS2
            // 
            LabelERS2.AutoSize = true;
            LabelERS2.Location = new Point(750, 115);
            LabelERS2.Name = "LabelERS2";
            LabelERS2.Size = new Size(33, 15);
            LabelERS2.TabIndex = 4;
            LabelERS2.Text = "E2 = ";
            // 
            // LabelDano
            // 
            LabelDano.AutoSize = true;
            LabelDano.Location = new Point(730, 160);
            LabelDano.Name = "LabelDano";
            LabelDano.Size = new Size(74, 15);
            LabelDano.TabIndex = 6;
            LabelDano.Text = "Нам відомі: ";
            // 
            // RadioButtonI
            // 
            RadioButtonI.AutoSize = true;
            RadioButtonI.Location = new Point(750, 190);
            RadioButtonI.Name = "RadioButtonI";
            RadioButtonI.Size = new Size(97, 19);
            RadioButtonI.TabIndex = 7;
            RadioButtonI.TabStop = true;
            RadioButtonI.Text = "Сили стриму";
            RadioButtonI.UseVisualStyleBackColor = true;
            RadioButtonI.CheckedChanged += RadioButtonI_CheckedChanged;
            // 
            // RadioButtonR
            // 
            RadioButtonR.AutoSize = true;
            RadioButtonR.Location = new Point(750, 220);
            RadioButtonR.Name = "RadioButtonR";
            RadioButtonR.Size = new Size(124, 19);
            RadioButtonR.TabIndex = 8;
            RadioButtonR.TabStop = true;
            RadioButtonR.Text = "Опори резисторів";
            RadioButtonR.UseVisualStyleBackColor = true;
            RadioButtonR.CheckedChanged += RadioButtonR_CheckedChanged;
            // 
            // LabelElement
            // 
            LabelElement.AutoSize = true;
            LabelElement.Location = new Point(0, 0);
            LabelElement.Name = "LabelElement";
            LabelElement.Size = new Size(182, 15);
            LabelElement.TabIndex = 9;
            LabelElement.Text = "Сили струму/Опори резисторів";
            // 
            // LabelElement1
            // 
            LabelElement1.AutoSize = true;
            LabelElement1.Location = new Point(20, 40);
            LabelElement1.Name = "LabelElement1";
            LabelElement1.Size = new Size(48, 15);
            LabelElement1.TabIndex = 10;
            LabelElement1.Text = "I1/R1 = ";
            // 
            // TextBoxElement1
            // 
            TextBoxElement1.Location = new Point(58, 36);
            TextBoxElement1.Name = "TextBoxElement1";
            TextBoxElement1.Size = new Size(100, 23);
            TextBoxElement1.TabIndex = 11;
            // 
            // LabelElement2
            // 
            LabelElement2.AutoSize = true;
            LabelElement2.Location = new Point(20, 85);
            LabelElement2.Name = "LabelElement2";
            LabelElement2.Size = new Size(48, 15);
            LabelElement2.TabIndex = 12;
            LabelElement2.Text = "I2/R2 = ";
            // 
            // TextBoxElement2
            // 
            TextBoxElement2.Location = new Point(58, 81);
            TextBoxElement2.Name = "TextBoxElement2";
            TextBoxElement2.Size = new Size(100, 23);
            TextBoxElement2.TabIndex = 13;
            // 
            // LabelElement3
            // 
            LabelElement3.AutoSize = true;
            LabelElement3.Location = new Point(20, 130);
            LabelElement3.Name = "LabelElement3";
            LabelElement3.Size = new Size(48, 15);
            LabelElement3.TabIndex = 14;
            LabelElement3.Text = "I3/R3 = ";
            // 
            // TextBoxElement3
            // 
            TextBoxElement3.Location = new Point(58, 126);
            TextBoxElement3.Name = "TextBoxElement3";
            TextBoxElement3.Size = new Size(100, 23);
            TextBoxElement3.TabIndex = 15;
            // 
            // GetResult
            // 
            GetResult.Location = new Point(600, 445);
            GetResult.Name = "GetResult";
            GetResult.Size = new Size(85, 25);
            GetResult.TabIndex = 16;
            GetResult.Text = "Розрахувати";
            GetResult.UseVisualStyleBackColor = true;
            GetResult.Click += GetResult_Click;
            // 
            // PanelResult
            // 
            PanelResult.Controls.Add(TextBoxResultOm3);
            PanelResult.Controls.Add(LabelOm3);
            PanelResult.Controls.Add(TextBoxResultOm2);
            PanelResult.Controls.Add(LabelOm2);
            PanelResult.Controls.Add(TextBoxResultOm1);
            PanelResult.Controls.Add(LabelOm1);
            PanelResult.Controls.Add(LabelTextOm);
            PanelResult.Controls.Add(TextBoxResultElement3);
            PanelResult.Controls.Add(LabelResultElement3);
            PanelResult.Controls.Add(TextBoxResultElement2);
            PanelResult.Controls.Add(LabelResultElement2);
            PanelResult.Controls.Add(TextBoxResultElement1);
            PanelResult.Controls.Add(LabelResultElement1);
            PanelResult.Controls.Add(LabelTextResult);
            PanelResult.Location = new Point(940, 30);
            PanelResult.Name = "PanelResult";
            PanelResult.Size = new Size(220, 400);
            PanelResult.TabIndex = 17;
            // 
            // TextBoxResultOm3
            // 
            TextBoxResultOm3.Location = new Point(60, 297);
            TextBoxResultOm3.Name = "TextBoxResultOm3";
            TextBoxResultOm3.ReadOnly = true;
            TextBoxResultOm3.Size = new Size(100, 23);
            TextBoxResultOm3.TabIndex = 13;
            // 
            // LabelOm3
            // 
            LabelOm3.AutoSize = true;
            LabelOm3.Location = new Point(20, 300);
            LabelOm3.Name = "LabelOm3";
            LabelOm3.Size = new Size(35, 15);
            LabelOm3.TabIndex = 12;
            LabelOm3.Text = "U3 = ";
            // 
            // TextBoxResultOm2
            // 
            TextBoxResultOm2.Location = new Point(60, 252);
            TextBoxResultOm2.Name = "TextBoxResultOm2";
            TextBoxResultOm2.ReadOnly = true;
            TextBoxResultOm2.Size = new Size(100, 23);
            TextBoxResultOm2.TabIndex = 11;
            // 
            // LabelOm2
            // 
            LabelOm2.AutoSize = true;
            LabelOm2.Location = new Point(20, 255);
            LabelOm2.Name = "LabelOm2";
            LabelOm2.Size = new Size(35, 15);
            LabelOm2.TabIndex = 10;
            LabelOm2.Text = "U2 = ";
            // 
            // TextBoxResultOm1
            // 
            TextBoxResultOm1.Location = new Point(60, 207);
            TextBoxResultOm1.Name = "TextBoxResultOm1";
            TextBoxResultOm1.ReadOnly = true;
            TextBoxResultOm1.Size = new Size(100, 23);
            TextBoxResultOm1.TabIndex = 9;
            // 
            // LabelOm1
            // 
            LabelOm1.AutoSize = true;
            LabelOm1.Location = new Point(20, 210);
            LabelOm1.Name = "LabelOm1";
            LabelOm1.Size = new Size(35, 15);
            LabelOm1.TabIndex = 8;
            LabelOm1.Text = "U1 = ";
            // 
            // LabelTextOm
            // 
            LabelTextOm.AutoSize = true;
            LabelTextOm.Location = new Point(0, 170);
            LabelTextOm.Name = "LabelTextOm";
            LabelTextOm.Size = new Size(57, 15);
            LabelTextOm.TabIndex = 7;
            LabelTextOm.Text = "Напруги:";
            // 
            // TextBoxResultElement3
            // 
            TextBoxResultElement3.Location = new Point(60, 127);
            TextBoxResultElement3.Name = "TextBoxResultElement3";
            TextBoxResultElement3.ReadOnly = true;
            TextBoxResultElement3.Size = new Size(100, 23);
            TextBoxResultElement3.TabIndex = 6;
            // 
            // LabelResultElement3
            // 
            LabelResultElement3.AutoSize = true;
            LabelResultElement3.Location = new Point(20, 130);
            LabelResultElement3.Name = "LabelResultElement3";
            LabelResultElement3.Size = new Size(48, 15);
            LabelResultElement3.TabIndex = 5;
            LabelResultElement3.Text = "I3/R3 = ";
            // 
            // TextBoxResultElement2
            // 
            TextBoxResultElement2.Location = new Point(60, 82);
            TextBoxResultElement2.Name = "TextBoxResultElement2";
            TextBoxResultElement2.ReadOnly = true;
            TextBoxResultElement2.Size = new Size(100, 23);
            TextBoxResultElement2.TabIndex = 4;
            // 
            // LabelResultElement2
            // 
            LabelResultElement2.AutoSize = true;
            LabelResultElement2.Location = new Point(20, 85);
            LabelResultElement2.Name = "LabelResultElement2";
            LabelResultElement2.Size = new Size(48, 15);
            LabelResultElement2.TabIndex = 3;
            LabelResultElement2.Text = "I2/R2 = ";
            // 
            // TextBoxResultElement1
            // 
            TextBoxResultElement1.Location = new Point(60, 37);
            TextBoxResultElement1.Name = "TextBoxResultElement1";
            TextBoxResultElement1.ReadOnly = true;
            TextBoxResultElement1.Size = new Size(100, 23);
            TextBoxResultElement1.TabIndex = 2;
            // 
            // LabelResultElement1
            // 
            LabelResultElement1.AutoSize = true;
            LabelResultElement1.Location = new Point(20, 40);
            LabelResultElement1.Name = "LabelResultElement1";
            LabelResultElement1.Size = new Size(48, 15);
            LabelResultElement1.TabIndex = 1;
            LabelResultElement1.Text = "I1/R1 = ";
            // 
            // LabelTextResult
            // 
            LabelTextResult.AutoSize = true;
            LabelTextResult.Location = new Point(0, 0);
            LabelTextResult.Name = "LabelTextResult";
            LabelTextResult.Size = new Size(136, 15);
            LabelTextResult.TabIndex = 0;
            LabelTextResult.Text = "Результати розрахунку:";
            // 
            // PanelInputElement
            // 
            PanelInputElement.Controls.Add(LabelElement);
            PanelInputElement.Controls.Add(LabelElement1);
            PanelInputElement.Controls.Add(TextBoxElement1);
            PanelInputElement.Controls.Add(TextBoxElement3);
            PanelInputElement.Controls.Add(LabelElement2);
            PanelInputElement.Controls.Add(LabelElement3);
            PanelInputElement.Controls.Add(TextBoxElement2);
            PanelInputElement.Location = new Point(730, 260);
            PanelInputElement.Name = "PanelInputElement";
            PanelInputElement.Size = new Size(200, 158);
            PanelInputElement.TabIndex = 18;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 481);
            Controls.Add(PanelInputElement);
            Controls.Add(PanelResult);
            Controls.Add(GetResult);
            Controls.Add(RadioButtonR);
            Controls.Add(RadioButtonI);
            Controls.Add(LabelDano);
            Controls.Add(TextBoxERS2);
            Controls.Add(LabelERS2);
            Controls.Add(TextBoxERS1);
            Controls.Add(LabelERS1);
            Controls.Add(LabelElementERS);
            Controls.Add(MainPicture);
            Name = "MainWindow";
            Text = "Лабораторна робота №1";
            ((System.ComponentModel.ISupportInitialize)MainPicture).EndInit();
            PanelResult.ResumeLayout(false);
            PanelResult.PerformLayout();
            PanelInputElement.ResumeLayout(false);
            PanelInputElement.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox MainPicture;
        private Label LabelElementERS;
        private Label LabelERS1;
        private TextBox TextBoxERS1;
        private TextBox TextBoxERS2;
        private Label LabelERS2;
        private Label LabelDano;
        private RadioButton RadioButtonI;
        private RadioButton RadioButtonR;
        private Label LabelElement;
        private Label LabelElement1;
        private TextBox TextBoxElement1;
        private Label LabelElement2;
        private TextBox TextBoxElement2;
        private Label LabelElement3;
        private TextBox TextBoxElement3;
        private Button GetResult;
        private Panel PanelResult;
        private Label LabelTextResult;
        private Label LabelResultElement1;
        private Label LabelResultElement2;
        private TextBox TextBoxResultElement1;
        private TextBox TextBoxResultElement2;
        private TextBox TextBoxResultElement3;
        private Label LabelResultElement3;
        private Label LabelOm1;
        private Label LabelTextOm;
        private Label LabelOm2;
        private TextBox TextBoxResultOm1;
        private Label LabelOm3;
        private TextBox TextBoxResultOm2;
        private TextBox TextBoxResultOm3;
        private Panel PanelInputElement;
    }
}