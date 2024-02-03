namespace Calculations
{
    public class Calculation
    {
        public double[,] CalcOnAllERSI(double[,] data)
        {
            double[,] result = new double[3, 3];
            
            double determinant = data[1,0] * (-data[1,2]) - (data[1, 1] * ((data[1,0] + data[1,2])));
            // R1 * (-R3) - (R2*(R1+R3))

            result[0, 1] = Math.Round((data[0,0] * (-data[1,2]) - ((-data[0, 1]) * 
                (data[1,0] + data[1,2])))/determinant, 4,MidpointRounding.AwayFromZero);
            // current 2 = E1*(-R3) - (-E2)*(R1+R3)/determinant

            result[0, 2] = Math.Round(((data[1, 0] * (-data[0,1])) - (data[1,1] * 
                data[0,0]))/determinant, 4, MidpointRounding.AwayFromZero);
            // current 3 = (R1*(-E2) - R2*E1)/determinant

            result[0, 0] = Math.Round(result[0, 1] + result[0, 2], 4,MidpointRounding.AwayFromZero); 
            // current 1 = current 2 + current 3

            result[1, 0] = Math.Round(result[0, 0] * data[1, 0], 4,MidpointRounding.AwayFromZero);
            result[1, 1] = Math.Round(result[0, 1] * data[1, 1], 4, MidpointRounding.AwayFromZero);
            result[1, 2] = Math.Round(result[0, 2] * data[1, 2], 4, MidpointRounding.AwayFromZero);
            return result;
        }

        public double[,] CalcOnAllERSR(double[,] data)
        {
            double[,] result = new double[3, 3];

            double determinant = (-1) * data[1, 0] * data[1, 1] - 2 * data[1, 2] * data[1, 1] - (-1) * data[1, 0] * (-data[1, 2]);
            // -1 * I1 * I2 - 2 * I3 * I2 - (-1) * I1 * (-I3)

            result[0, 0] = Math.Round(( ( - data[0, 1] ) * data[1, 2] * ( -1 ) + 
                ( -1 ) * data[0, 0] * data[1, 1] - 
                ( - data[1, 2] ) * data[0, 0] * ( -1 ) )/determinant, 4, MidpointRounding.AwayFromZero);
            // resistor 1 = (-E2 * I3 * (-1) + (-1) * E1 * I2 - (-I3) * E1 * (-1)) / determinant

            result[0, 1] = Math.Round(( 2 * data[0, 0] * ( - data[1, 2] ) + 
                ( -1 ) * data[1, 0] * ( - data[0, 1] ) - 
                2 * data[1, 2] * ( - data[0, 1] ) )/determinant,4,MidpointRounding.AwayFromZero);
            // resistor 2 = (2 * E1 * (-I3) + (-1) * I1 * (-E2) - 2 * I3 * (-E2) ) / determinant

            result[0, 2] = Math.Round((-2 * data[0, 0] * data[1, 1] - 
                ( -1 ) * data[1, 0] * ( -data[0, 1] ) ) / determinant, 4, MidpointRounding.AwayFromZero);
            // resistor 3 = (-2 * E1 * I2 - (-1) * I1 * (-E2) ) / determinant

            result[1, 0] = Math.Round(result[0, 0] * data[1, 0], 4, MidpointRounding.AwayFromZero);
            result[1, 1] = Math.Round(result[0, 1] * data[1, 1], 4, MidpointRounding.AwayFromZero);
            result[1, 2] = Math.Round(result[0, 2] * data[1, 2], 4, MidpointRounding.AwayFromZero);
            return result;
        }

        public double[,] CalcShortCircuit(double[,] data, double[,] result_element, char type)
        {
            double[,] result = new double[3,3];
            if (type == 'i')
            {
                result[0, 0] = Math.Round(data[1, 0] + data[1, 1], 4, MidpointRounding.AwayFromZero);
            } else
            {
                result[0, 0] = Math.Round(result_element[0, 0] + result_element[0, 1], 4, MidpointRounding.AwayFromZero);
            }
        
            result[0, 1] = Math.Round(data[0, 1] + data[1, 0] * result_element[0, 0], 4, MidpointRounding.AwayFromZero);
            return result;
        }

        public double[,] CalcVariousSupports(double[,] data, int[] Element)
        {
            double[,] result = new double[3, 3];
            double[] temp_data = new double[2];
            if (Element[1] == -1 )
            {
                temp_data[0] = data[1, Element[0]];
            } else
            {
                if (Element[0] == 2)
                {
                    temp_data[0] = (data[1, Element[0]] * data[1, Element[1]]) /
                    (data[1, Element[0]] + data[1, Element[1]]);
                }
                else
                {
                    temp_data[0] = data[1, Element[0]] + data[1, Element[1]];
                }
            }
            temp_data[1] = data[0, 0] / temp_data[0];
            result[0, 0] = Math.Round(Math.Pow(temp_data[1], 2) * temp_data[0], 4, MidpointRounding.AwayFromZero);
            result[1, Element[0]] = Math.Round(Math.Sqrt(result[0, 0] * data[1, Element[0]]), 4, MidpointRounding.AwayFromZero);
            if (Element[1] != -1) { result[1, Element[1]] = Math.Round(Math.Sqrt(result[0, 0] * data[1, Element[1]]), 4, MidpointRounding.AwayFromZero); }
            return result;
        }
    } 
}