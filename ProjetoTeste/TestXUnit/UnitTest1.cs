using ProjetoTeste;
using Xunit;

namespace TestXUnit
{
    public class UnitTest1
    {
        [Fact]
        public void SomarDoisNumero()
        {
            //Prepara��o
            double pNumero = 1;
            double sNumero = 1;
            double rNumero = 2;

            //A��o
            var resultado = Operacoes.Somar(pNumero, sNumero);

            //Verifica��o
            Assert.Equal(rNumero, resultado);    
        

        }
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(1, 2, 3)]
        [InlineData(1, 3, 4)]
        public void SomarDoisNumerodLista(double pNumero, double sNumero, double rNumero)
        {
            //A��o
            var resultado = Operacoes.Somar(pNumero, sNumero);

            //Assert
            Assert.Equal(rNumero, resultado);
        }

    }
}