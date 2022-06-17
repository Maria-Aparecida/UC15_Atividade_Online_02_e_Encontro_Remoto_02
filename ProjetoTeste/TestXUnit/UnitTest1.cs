using ProjetoTeste;
using Xunit;

namespace TestXUnit
{
    public class UnitTest1
    {
        [Fact]
        public void SomarDoisNumero()
        {
            //Preparação
            double pNumero = 1;
            double sNumero = 1;
            double rNumero = 2;

            //Ação
            var resultado = Operacoes.Somar(pNumero, sNumero);

            //Verificação
            Assert.Equal(rNumero, resultado);    
        

        }
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(1, 2, 3)]
        [InlineData(1, 3, 4)]
        public void SomarDoisNumerodLista(double pNumero, double sNumero, double rNumero)
        {
            //Ação
            var resultado = Operacoes.Somar(pNumero, sNumero);

            //Assert
            Assert.Equal(rNumero, resultado);
        }

    }
}