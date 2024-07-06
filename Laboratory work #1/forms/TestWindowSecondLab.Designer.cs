namespace Laboratory_work__1
{
    partial class TestWindowSecondLab
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
            PanelQuestion = new Panel();
            RadioButtonAnswer5 = new RadioButton();
            ButtonBack = new Button();
            ButtonNext = new Button();
            PictureQuestion = new PictureBox();
            RadioButtonAnswer4 = new RadioButton();
            RadioButtonAnswer3 = new RadioButton();
            RadioButtonAnswer2 = new RadioButton();
            RadionButtonAnswer1 = new RadioButton();
            LabelQuestion = new Label();
            PanelQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureQuestion).BeginInit();
            SuspendLayout();
            // 
            // PanelQuestion
            // 
            PanelQuestion.BorderStyle = BorderStyle.FixedSingle;
            PanelQuestion.Controls.Add(RadioButtonAnswer5);
            PanelQuestion.Controls.Add(ButtonBack);
            PanelQuestion.Controls.Add(ButtonNext);
            PanelQuestion.Controls.Add(PictureQuestion);
            PanelQuestion.Controls.Add(RadioButtonAnswer4);
            PanelQuestion.Controls.Add(RadioButtonAnswer3);
            PanelQuestion.Controls.Add(RadioButtonAnswer2);
            PanelQuestion.Controls.Add(RadionButtonAnswer1);
            PanelQuestion.Controls.Add(LabelQuestion);
            PanelQuestion.Location = new Point(12, 12);
            PanelQuestion.Name = "PanelQuestion";
            PanelQuestion.Size = new Size(820, 475);
            PanelQuestion.TabIndex = 0;
            // 
            // RadioButtonAnswer5
            // 
            RadioButtonAnswer5.AutoSize = true;
            RadioButtonAnswer5.Location = new Point(80, 360);
            RadioButtonAnswer5.Name = "RadioButtonAnswer5";
            RadioButtonAnswer5.Size = new Size(146, 19);
            RadioButtonAnswer5.TabIndex = 8;
            RadioButtonAnswer5.TabStop = true;
            RadioButtonAnswer5.Text = "radio_button_answer_5";
            RadioButtonAnswer5.UseVisualStyleBackColor = true;
            // 
            // ButtonBack
            // 
            ButtonBack.Location = new Point(80, 430);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(82, 23);
            ButtonBack.TabIndex = 7;
            ButtonBack.Text = "Попереднє";
            ButtonBack.UseVisualStyleBackColor = true;
            ButtonBack.Click += ButtonBack_Click;
            // 
            // ButtonNext
            // 
            ButtonNext.Location = new Point(670, 430);
            ButtonNext.Name = "ButtonNext";
            ButtonNext.Size = new Size(75, 23);
            ButtonNext.TabIndex = 6;
            ButtonNext.Text = "Наступне";
            ButtonNext.UseVisualStyleBackColor = true;
            ButtonNext.Click += ButtonNext_Click;
            // 
            // PictureQuestion
            // 
            PictureQuestion.Location = new Point(440, 120);
            PictureQuestion.Name = "PictureQuestion";
            PictureQuestion.Size = new Size(100, 50);
            PictureQuestion.SizeMode = PictureBoxSizeMode.AutoSize;
            PictureQuestion.TabIndex = 5;
            PictureQuestion.TabStop = false;
            // 
            // RadioButtonAnswer4
            // 
            RadioButtonAnswer4.AutoSize = true;
            RadioButtonAnswer4.Location = new Point(80, 300);
            RadioButtonAnswer4.Name = "RadioButtonAnswer4";
            RadioButtonAnswer4.Size = new Size(146, 19);
            RadioButtonAnswer4.TabIndex = 4;
            RadioButtonAnswer4.TabStop = true;
            RadioButtonAnswer4.Text = "radio_button_answer_4";
            RadioButtonAnswer4.UseVisualStyleBackColor = true;
            // 
            // RadioButtonAnswer3
            // 
            RadioButtonAnswer3.AutoSize = true;
            RadioButtonAnswer3.Location = new Point(80, 240);
            RadioButtonAnswer3.Name = "RadioButtonAnswer3";
            RadioButtonAnswer3.Size = new Size(146, 19);
            RadioButtonAnswer3.TabIndex = 3;
            RadioButtonAnswer3.TabStop = true;
            RadioButtonAnswer3.Text = "radio_button_asnwer_3";
            RadioButtonAnswer3.UseVisualStyleBackColor = true;
            // 
            // RadioButtonAnswer2
            // 
            RadioButtonAnswer2.AutoSize = true;
            RadioButtonAnswer2.Location = new Point(80, 180);
            RadioButtonAnswer2.Name = "RadioButtonAnswer2";
            RadioButtonAnswer2.Size = new Size(146, 19);
            RadioButtonAnswer2.TabIndex = 2;
            RadioButtonAnswer2.TabStop = true;
            RadioButtonAnswer2.Text = "radio_button_answer_2";
            RadioButtonAnswer2.UseVisualStyleBackColor = true;
            // 
            // RadionButtonAnswer1
            // 
            RadionButtonAnswer1.AutoSize = true;
            RadionButtonAnswer1.Location = new Point(80, 120);
            RadionButtonAnswer1.Name = "RadionButtonAnswer1";
            RadionButtonAnswer1.Size = new Size(146, 19);
            RadionButtonAnswer1.TabIndex = 1;
            RadionButtonAnswer1.TabStop = true;
            RadionButtonAnswer1.Text = "radio_button_answer_1";
            RadionButtonAnswer1.UseVisualStyleBackColor = true;
            // 
            // LabelQuestion
            // 
            LabelQuestion.AutoSize = true;
            LabelQuestion.Location = new Point(55, 60);
            LabelQuestion.MaximumSize = new Size(700, 0);
            LabelQuestion.Name = "LabelQuestion";
            LabelQuestion.Size = new Size(83, 15);
            LabelQuestion.TabIndex = 0;
            LabelQuestion.Text = "label_question";
            // 
            // TestWindowSecondLab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 501);
            Controls.Add(PanelQuestion);
            Name = "TestWindowSecondLab";
            Text = "Лабораторна робота №2. Тестові запитання";
            PanelQuestion.ResumeLayout(false);
            PanelQuestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureQuestion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelQuestion;
        private Label LabelQuestion;
        private RadioButton RadionButtonAnswer1;
        private RadioButton RadioButtonAnswer3;
        private RadioButton RadioButtonAnswer2;
        private PictureBox PictureQuestion;
        private RadioButton RadioButtonAnswer4;
        private Button ButtonNext;
        private Button ButtonBack;
        private RadioButton RadioButtonAnswer5;
    }
}