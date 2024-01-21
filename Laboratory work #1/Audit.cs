using Calculations;

namespace Audits
{
    public class Audit
    {
        Calculation Calculation = new Calculation();
        public double[,] CheckShem(bool[] Switches, double[,] data)
        {
            double[,] result = new double[3, 3];

            if (Switches[5] && Switches[6])
            {
                if (Switches[0] && Switches[1] && Switches[2])
                {
                    result = Calculation.CalcOnAllERSR(data);
                }
            }

            return result;
        }

        public double[,] CheckInput(TextBox[] TextBoxes)
        {
            double[,] data = new double[2, 3];
            string result = "";
            int index = 0;

            for (int i = 0;i < 5; i++)
            {
                if (TextBoxes[i].Text == "")
                {
                    result = "Не заповнені всі значення елементів";
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

                            data[i,j] = Convert.ToDouble(TextBoxes[index].Text);
                            index++;
                        }
                    }
                }
            }

            return data;
        }
    }
}