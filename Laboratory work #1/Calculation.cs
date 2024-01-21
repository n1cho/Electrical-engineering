namespace Calculations
{
    public class Calculation
    {
        public double[,] CalcOnAllERSR(double[,] data)
        {
            double[,] result = new double[3, 3];
            
            double determinant = data[1,0] * (-data[1,2]) - (data[1, 1] * ((data[1,0] + data[1,2])));
            // R1 * (-R3) - (R2*(R1+R3))

            result[0, 1] = Math.Round((data[0,0] * (-data[1,2]) - ((-data[0, 1]) * (data[1,0] + data[1,2])))/determinant,4,MidpointRounding.AwayFromZero);
            // current 2 = E1*(-R3) - (-E2)*(R1+R3)/determinant

            result[0, 2] = Math.Round(((data[1, 0] * (-data[0,1])) - (data[1,1] * data[0,0]))/determinant,4, MidpointRounding.AwayFromZero);
            // current 3 = (R1*(-E2) - R2*E1)/determinant

            result[0, 0] = Math.Round(result[0, 1] + result[0, 2],4,MidpointRounding.AwayFromZero); // current 1

            result[1, 0] = Math.Round(result[0, 0] * data[1, 0],4,MidpointRounding.AwayFromZero);
            result[1, 1] = Math.Round(result[0, 1] * data[1, 1], 4, MidpointRounding.AwayFromZero);
            result[1, 2] = Math.Round(result[0, 2] * data[1, 2], 4, MidpointRounding.AwayFromZero);
            return result;
        }
    } 
}