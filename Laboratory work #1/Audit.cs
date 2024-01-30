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
                if (Switches[2])
                {
                    if (Switches[0] || Switches[1])
                    {
                        if (!Switches[0]) { data[0, 0] = 0; } else if (!Switches[1]) { data[0, 1] = 0; }
                    }
                    
                    if (Type == 'r')
                    {
                        result = Calculation.CalcOnAllERSI(data);
                    } else if (Type == 'i')
                    {
                        if (Math.Round(data[1, 0] - data[1, 1] - data[1, 2], 0, MidpointRounding.AwayFromZero) == 0)
                        {
                            result = Calculation.CalcOnAllERSR(data);
                        } else
                        {
                            MessageBox.Show("Сума струмів має бути рівна нулю", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    if (Switches[3])
                    {
                        result = Calculation.CalcShortCircuit(data, result, Type);
                    }
                } else if (Switches[0] && !Switches[1] && !Switches[2])
                {
                    if (Switches[4])
                    {
                        if (Type == 'r') { result = Calculation.CalcVariousSupports(data, 1); }
                    }
                }
            } else if (Switches[5] && !Switches[6])
            {
                if (Switches[0] && !Switches[1] && Switches[2])
                {
                    if (Switches[3])
                    {
                        if (Type == 'r') { result = Calculation.CalcVariousSupports(data, 0); }
                    } else if (!Switches[3])
                    {
                        if (Type == 'r') { result = Calculation.CalcVariousSupports(data, 2); }
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