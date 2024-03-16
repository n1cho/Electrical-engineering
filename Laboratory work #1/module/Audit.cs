using Calculations;

namespace Audits
{
    public class Audit
    {
        Calculation Calculation = new Calculation();
        public string CheckShem(bool[] Switches, char Type)
        {
            string result = String.Empty;
            if (Switches[5] && Switches[6])
            {
                if (Switches[2])
                {
                    if (Switches[0] && Switches[1]) { 
                        if (!Switches[3] && !Switches[4]) {
                            if (Type == 'i') { result = "DefaultAllERSI"; } 
                            else if (Type == 'r') { result = "DefaultAllERSR"; }
                        }  
                        else if (Switches[3] && !Switches[4]) { result = "ShortCircuitIkz"; }
                    }
                    else if (Switches[0] && !Switches[1])
                    {
                        if (Switches[4] && !Switches[3]) { result = "VariousSupportsR2R3"; }
                        else if (!Switches[4] && Switches[3]) { result = "VariousSupportsR1R2"; }
                        else {
                            if (Type == 'i') { result = "DefaultERS1I"; }
                            else if (Type == 'r') { result = "DefaultERS1R"; }
                        }
                    }
                    else if (!Switches[0] && Switches[1]) {
                        if (Type == 'i') { result = "DefaultERS2I"; }
                        else if (Type == 'r') { result = "DefaultERS2R"; }
                    }
                } else if (!Switches[2])
                {
                    if (Switches[0] && !Switches[1])
                    {
                        if (!Switches[4]) { result = "VariousSupportsR1R2"; }
                        else if (Switches[4]) { result = "VariousSupportsR2"; }
                    } else if (Switches[0] && Switches[1])
                    {
                        if (!Switches[3] && !Switches[4]) { result = "ShortCircuitUxx"; }
                    }
                }
            } else if (Switches[5] && !Switches[6])
            {
                if (Switches[2])
                {
                    if (Switches[3] && !Switches[1] && !Switches[4])
                    {
                        result = "VariousSupportsR1";
                    }
                    else if (Switches[4] && !Switches[3])
                    {
                        result = "VariousSupportsR3";
                    } else if (!Switches[3] && !Switches[4]) { result = "VariousSupportsR1R3"; }
                }
            }
            return result;
        }

        public double[,] GetResult(string TypeShem, double[,] data, char Type)
        {
            // добавити вираховування коли дано струм
            double[,] result = new double[3, 3];
            if (TypeShem == "DefaultAllERSR" || TypeShem == "DefaultERS1R" || TypeShem == "DefaultERS2R")
            {
                if (TypeShem == "DefaultERS1R") { data[0, 1] = 0; }
                else if (TypeShem == "DefaultERS2R") { data[0, 0] = 0; }
                
                result = Calculation.CalcOnAllERSI(data);
            } 
            else if (TypeShem == "DefaultAllERSI" || TypeShem == "DefaultERS1I" || TypeShem == "DefaultERS2I")
            {
                if (TypeShem == "DefaultERS1I") { data[0, 1] = 0; }
                else if (TypeShem == "DefaultERS2I") { data[0, 0] = 0; }

                if (Math.Round(data[1, 0] - data[1, 1] - data[1, 2], 0, MidpointRounding.AwayFromZero) == 0)
                {
                    result = Calculation.CalcOnAllERSR(data);
                }
                else
                {
                    MessageBox.Show("Сума струмів має бути рівна нулю", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (TypeShem == "ShortCircuitUxx") { result = Calculation.CalcShortCircuit(data,0); } 
            else if (TypeShem == "ShortCircuitIkz") { result = Calculation.CalcShortCircuit(data, 1); }
            else if (TypeShem == "VariousSupportsR1" || TypeShem == "VariousSupportsR2" || TypeShem == "VariousSupportsR3" ||
                TypeShem == "VariousSupportsR1R2" ||  TypeShem == "VariousSupportsR1R3" || TypeShem == "VariousSupportsR2R3")
            {
                if (Type == 'r')
                {
                    int[] array_element = new int[2];
                    if (TypeShem == "VariousSupportsR1") { array_element[0] = 0; array_element[1] = -1; }
                    else if (TypeShem == "VariousSupportsR2") { array_element[0] = 1; array_element[1] = -1; }
                    else if (TypeShem == "VariousSupportsR3") { array_element[0] = 2; array_element[1] = -1; }
                    else if (TypeShem == "VariousSupportsR1R2") { array_element[0] = 0; array_element[1] = 1; }
                    else if (TypeShem == "VariousSupportsR1R3") { array_element[0] = 0; array_element[1] = 2; }
                    else if (TypeShem == "VariousSupportsR2R3") { array_element[0] = 1; array_element[1] = 2; }
                    result = Calculation.CalcVariousSupports(data, array_element);
                }
            }
            return result;
        }

        public double[,] CheckInput(TextBox[] TextBoxes, char Type)
        {
            double[,] data = new double[2, 4];
            string[] elements = { "E1", "E2", "1", "2", "3", "R1" };
            string result = "";
            int index = 0;
            int range = 0;

            if (Type == 'i') { range = 6; } else if (Type == 'r') { range = 5; }

            for (int i = 0;i < range; i++)
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
                if (Type == 'i')
                {
                    data[1, 3] = Convert.ToDouble(TextBoxes[5].Text);
                }
            }

            return data;
        }
    }
}