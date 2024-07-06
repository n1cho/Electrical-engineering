namespace Testings
{
    public class Testing
    {
        public void ChangeQuestion(Dictionary<string,int> Data, string[,,] questions, RadioButton[] Buttons, Label Title, PictureBox Picture)
        {
            if (Data["Question"] < Data["Range"])
            {
                Title.Text = questions[Data["Variant"], Data["Question"], 0];
                for (int i = 1; i < Data["Answers"]; i++)
                {
                    if (questions[Data["Variant"], Data["Question"], i] == "none")
                    {
                        Buttons[i - 1].Visible = false;
                    }
                    else
                    {
                        if (!Buttons[i - 1].Visible) { Buttons[i - 1].Visible = true; }
                        Buttons[i - 1].Text = questions[Data["Variant"], Data["Question"], i];
                    }
                }
                if (questions[Data["Variant"], Data["Question"], Data["Answers"] ] != "none")
                {
                    if (!Picture.Visible) { Picture.Visible = true; }
                    Picture.Image = Laboratory_work__1.Properties.Resources.ResourceManager.GetObject(
                        questions[Data["Variant"], Data["Question"], 5]) as Image;
                }
                else
                {
                    Picture.Visible = false;
                }
            }
        }

        public void CheckAnswer(char Type, Dictionary<string, int> Data, char[] GetAnswer, RadioButton[] Buttons)
        {
            char[] Letter = { 'а', 'б', 'в', 'г', 'д' };
            if (Type == 'w')
            {
                for (int i = 0; i < Data["Answers"]-1; i++)
                {
                    if (Buttons[i].Checked) { GetAnswer[Data["Question"]] = Letter[i]; }
                }
            }
            else if (Type == 'c')
            {
                for (int i = 0; i < Data["Answers"]-1; i++)
                {
                    if (Letter[i] == GetAnswer[Data["Question"]])
                    {
                        Buttons[i].Checked = true;
                    }
                }
            }
        }

        public int GetResult(char[] Answers, char[,] GoodAnswers, Dictionary<string, int> Data)
        {
            int result = 0;
            for (int i = 0; i < Data["Range"]; i++)
            {
                if (Answers[i] == GoodAnswers[Data["Variant"], i]) { result++; }
            }
            return result;
        }

    }
}
