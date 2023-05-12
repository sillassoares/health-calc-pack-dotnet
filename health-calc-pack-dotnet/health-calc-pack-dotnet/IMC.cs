using health_calc_pack_dotnet.Interfaces;
using System.Numerics;

namespace health_calc_pack_dotnet
{
    public class IMC : IIMC
    {
        public double Calc(double Height, double Weight)
        {
            if (!this.IsValidData(Height, Weight))
            {
                return 0;
            }
            double calculo = Weight / Math.Pow(Height, 2);
            return Math.Round(calculo,2);
        }

        public string GetIMCCategory(double IMC)
        {
            if (IMC < 18.5)
                return "MAGREZA";
            if (IMC < 25)
                return "NORMAL";
            if (IMC < 30)
                return "SOBREPESO";
            if (IMC < 40)
                return "OBESIDADE";
            return "OBESIDADE GRAVE";
        }

        public bool IsValidData(double Height, double Weight)
        {
            return (Height < 3.0 && Weight <= 300);
        }
    }
}