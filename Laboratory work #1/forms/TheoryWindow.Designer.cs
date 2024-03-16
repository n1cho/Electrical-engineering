namespace Laboratory_work__1
{
    partial class TheoryWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheoryWindow));
            Label_tittle = new Label();
            Label_meta = new Label();
            Label_tittle_part1 = new Label();
            Label_part1_text1 = new Label();
            Label_subpart1_1 = new Label();
            Label_part1_text2 = new Label();
            TheoryPicture1_1 = new PictureBox();
            Label_part1_text3 = new Label();
            ((System.ComponentModel.ISupportInitialize)TheoryPicture1_1).BeginInit();
            SuspendLayout();
            // 
            // Label_tittle
            // 
            Label_tittle.AutoSize = true;
            Label_tittle.FlatStyle = FlatStyle.Flat;
            Label_tittle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Label_tittle.Location = new Point(200, 35);
            Label_tittle.Name = "Label_tittle";
            Label_tittle.Size = new Size(404, 38);
            Label_tittle.TabIndex = 0;
            Label_tittle.Text = "Лабораторна робота №1\r\nДослідження лінійного розгалуженого кола постійного струму\r\n";
            Label_tittle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label_meta
            // 
            Label_meta.AutoSize = true;
            Label_meta.Location = new Point(30, 100);
            Label_meta.MaximumSize = new Size(730, 0);
            Label_meta.Name = "Label_meta";
            Label_meta.Size = new Size(714, 30);
            Label_meta.TabIndex = 1;
            Label_meta.Text = "Мета роботи: Дослідження принципу накладання, принципу взаємності і теореми про еквівалентний генератор, закони Ома та Кіргхофа в лінійному електричному колі постійного струму";
            // 
            // Label_tittle_part1
            // 
            Label_tittle_part1.AutoSize = true;
            Label_tittle_part1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Label_tittle_part1.Location = new Point(30, 150);
            Label_tittle_part1.Name = "Label_tittle_part1";
            Label_tittle_part1.Size = new Size(255, 19);
            Label_tittle_part1.TabIndex = 2;
            Label_tittle_part1.Text = "1. ОСНОВНІ ТЕОРИТИЧНІ ВІДОМОСТІ";
            // 
            // Label_part1_text1
            // 
            Label_part1_text1.AutoSize = true;
            Label_part1_text1.Location = new Point(30, 175);
            Label_part1_text1.MaximumSize = new Size(750, 0);
            Label_part1_text1.Name = "Label_part1_text1";
            Label_part1_text1.Size = new Size(750, 105);
            Label_part1_text1.TabIndex = 3;
            Label_part1_text1.Text = resources.GetString("Label_part1_text1.Text");
            // 
            // Label_subpart1_1
            // 
            Label_subpart1_1.AutoSize = true;
            Label_subpart1_1.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            Label_subpart1_1.Location = new Point(30, 300);
            Label_subpart1_1.Name = "Label_subpart1_1";
            Label_subpart1_1.Size = new Size(94, 17);
            Label_subpart1_1.TabIndex = 4;
            Label_subpart1_1.Text = "1.1 Закон Ома";
            // 
            // Label_part1_text2
            // 
            Label_part1_text2.AutoSize = true;
            Label_part1_text2.Location = new Point(30, 325);
            Label_part1_text2.MaximumSize = new Size(750, 0);
            Label_part1_text2.Name = "Label_part1_text2";
            Label_part1_text2.Size = new Size(747, 90);
            Label_part1_text2.TabIndex = 5;
            Label_part1_text2.Text = resources.GetString("Label_part1_text2.Text");
            // 
            // TheoryPicture1_1
            // 
            TheoryPicture1_1.Image = Properties.Resources.theory_picture_1_1;
            TheoryPicture1_1.Location = new Point(240, 435);
            TheoryPicture1_1.Name = "TheoryPicture1_1";
            TheoryPicture1_1.Size = new Size(334, 165);
            TheoryPicture1_1.SizeMode = PictureBoxSizeMode.AutoSize;
            TheoryPicture1_1.TabIndex = 6;
            TheoryPicture1_1.TabStop = false;
            // 
            // Label_part1_text3
            // 
            Label_part1_text3.AutoSize = true;
            Label_part1_text3.Location = new Point(30, 620);
            Label_part1_text3.MaximumSize = new Size(750, 0);
            Label_part1_text3.Name = "Label_part1_text3";
            Label_part1_text3.Size = new Size(738, 30);
            Label_part1_text3.TabIndex = 7;
            Label_part1_text3.Text = "Закон Ома для активної ділянки електричного кола враховує значення та напрямок джерела ЕРС, дає можливість провести аналіз і розрахунок електричних кіл з одним джерелом живлення. ";
            // 
            // TheoryWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(804, 601);
            Controls.Add(Label_part1_text3);
            Controls.Add(TheoryPicture1_1);
            Controls.Add(Label_part1_text2);
            Controls.Add(Label_subpart1_1);
            Controls.Add(Label_part1_text1);
            Controls.Add(Label_tittle_part1);
            Controls.Add(Label_meta);
            Controls.Add(Label_tittle);
            Name = "TheoryWindow";
            Text = "TheoryWindow";
            ((System.ComponentModel.ISupportInitialize)TheoryPicture1_1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_tittle;
        private Label Label_meta;
        private Label Label_tittle_part1;
        private Label Label_part1_text1;
        private Label Label_subpart1_1;
        private Label Label_part1_text2;
        private PictureBox TheoryPicture1_1;
        private Label Label_part1_text3;
    }
}