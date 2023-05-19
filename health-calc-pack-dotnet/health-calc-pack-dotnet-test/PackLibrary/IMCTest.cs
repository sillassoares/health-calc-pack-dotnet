using health_calc_pack_dotnet;
using health_calc_pack_dotnet.Interfaces;

namespace health_calc_pack_dotnet_test.PackLibrary
{
    public class IMCTest
    {
        [Fact]
        public void Calc_ReturnsExpectedValue()
        {
            // Arrange
            IIMC imc = new IMC();
            double height = 1.75;
            double weight = 70;

            // Act
            double result = imc.Calc(height, weight);

            // Assert
            Assert.Equal(22.86, result);
        }

        [Fact]
        public void Calc_ReturnsZero_WhenHeightIsZero()
        {
            // Arrange
            IIMC imc = new IMC();
            double height = 0;
            double weight = 70;

            // Act
            double result = imc.Calc(height, weight);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Calc_ReturnsZero_WhenWeightIsZero()
        {
            // Arrange
            IIMC imc = new IMC();
            double height = 1.75;
            double weight = 0;

            // Act
            double result = imc.Calc(height, weight);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Calc_ReturnsExpectedValue_WhenHeightAndWeightAreNegative()
        {
            // Arrange
            IIMC imc = new IMC();
            double height = -1.75;
            double weight = -70;

            // Act
            double result = imc.Calc(height, weight);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void calculaIMC_QuandoDadosValidos_EntaoRetornaIndice()
        {

            //Arrange
            IIMC imc = new IMC();
            double Height = 1.72;
            double Weight = 78.2;
            double ExpectedIMC = 26.43;

            //Act
            var result = imc.Calc(Height, Weight);

            //Asserts
            Assert.Equal(ExpectedIMC, result);

        }

        [Fact]
        public void ValidaDados_IMCQuandoDadosValidos_EntaoRetornarVerdadeiro()
        {

            //Arrange
            IIMC imc = new IMC();
            double Height = 15.0;
            double Weight = 200.0;
            bool Expected = false;

            //Act
            var result = imc.IsValidData(Height, Weight);

            //Asserts
            Assert.Equal(Expected, result);

        }

        [Fact]
        public void ValidaDados_IMCQuandoDadosValidos_EntaoRetornarFalso()
        {

            //Arrange
            IIMC imc = new IMC();
            double Height = 10.0;
            double Weight = 400.0;
            bool Expected = false;

            //Act
            var result = imc.IsValidData(Height, Weight);

            //Asserts
            Assert.Equal(Expected, result);

        }

        [Theory]
        [InlineData(30.55, "OBESIDADE")]
        [InlineData(18, "MAGREZA")]
        [InlineData(50, "OBESIDADE GRAVE")]
        [InlineData(20, "NORMAL")]
        [InlineData(27, "SOBREPESO")]
        [InlineData(35, "OBESIDADE")]
        [InlineData(18.4, "MAGREZA")]
        [InlineData(18.5, "NORMAL")]
        [InlineData(40, "OBESIDADE GRAVE")]
        [InlineData(30, "OBESIDADE")]
        [InlineData(16.5, "MAGREZA")]
        [InlineData(24.9, "NORMAL")]
        [InlineData(25, "SOBREPESO")]
        [InlineData(29.9, "SOBREPESO")]
        [InlineData(39.9, "OBESIDADE")]
        public void RetornaCategoriaIMC_QuandoIndicenValido_EntaoRetornaCategoria(double ValorIMC, string Resultado)
        {

            //Arrange
            IIMC imc = new IMC();
            string Expected = Resultado;

            //Act
            var result = imc.GetIMCCategory(ValorIMC);

            //Asserts
            Assert.Equal(Expected, result);

        }

    }
}
