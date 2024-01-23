using Calculations;

namespace Audits
{
    public class Audit
    {
        Calculation Calculation = new Calculation();
        public double[,] CheckShem(bool[] Switches, double[,] data, char Type)
        {
            double[,] result = new double[3, 3];

            if (Switches[5] && Switches[6])
            {
                if (Switches[0] && Switches[1] && Switches[2])
                {
                    if (Type == 'r')
                    {
                        result = Calculation.CalcOnAllERSI(data);
                    }
                }
            }

            return result;
        }

        public double[,] CheckInput(TextBox[] TextBoxes, char Type)
        {
            double[,] data = new double[2, 3];
            string[] elements = { "E1", "E2", "1", "2", "3" };
            string result = "";
            int index = 0;

            for (int i = 0;i < 5; i++)
            {
                if (!TextBoxes[i].ReadOnly && TextBoxes[i].Text == "")
                {
                    if (i > 1)
                    {
                        result = "Не заповнено значення ";
                        if (Type == 'i') { result += "I" + elements[i]; } else { result += "R" + elements[i]; }
                    }
                    else
                    {
                        result = "Не заповненно значення " + elements[i];
                    }
                    MessageBox.Show(result, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }

            if (result == "")
            {
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (i == 0 && j == 2 )
                        {
                            continue;
                        }
                        else
                        {
                            if (TextBoxes[index].Text != "")
                            {
                                data[i, j] = Convert.ToDouble(TextBoxes[index].Text);
                            }
                            index++;
                        }
                    }
                }
            }

            return data;
        }
    }
}