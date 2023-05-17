using health_calc_pack_dotnet;
using health_calc_pack_dotnet.Enums;
using health_calc_pack_dotnet.Models;

namespace health_calc_pack_dotnet_test.PackLibrary
{
    public class MacroNutrientesTest
    {

        [Theory]
        [InlineData(ObjetivoFisicoEnum.PerderPeso, 231, 231, 308)]
        [InlineData(ObjetivoFisicoEnum.ManterPeso, 308, 154, 308)]
        [InlineData(ObjetivoFisicoEnum.GanharPeso, 308, 77, 154)]
        public void CalculaMacroNutrientes_QuandoDadosValidos_EntaoRetornaMacronutrientes(ObjetivoFisicoEnum ObjetivoFisico,
            double carboidratos, double gorduras, double proteinas)
        {
            //Arrange
            MacroNutrientes macroNutrientes = new MacroNutrientes();
            double Peso = 77;
            var Expected = new MacroNutrientesModel()
            {
                Carboidratos = carboidratos,
                Gorduras = gorduras,
                Proteinas = proteinas,
            };

            var result = macroNutrientes.CalcularMacroNutrientes(ObjetivoFisico, Peso);


            Assert.Equivalent(Expected, result);
        }
    }


}