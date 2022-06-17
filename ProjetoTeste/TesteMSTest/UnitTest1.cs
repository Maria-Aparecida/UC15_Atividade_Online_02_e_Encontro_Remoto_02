using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoTeste;

namespace TesteMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SomarDoisNumeros()
        {
            //Preparação
            double primerioNumero = 1;
            double segundoNumero = 2;
            double rNum= 3;

            //Ação
            var resultado = Operacoes.Somar(primerioNumero, segundoNumero);


            //Verificação
            Assert.AreEqual(rNum, resultado);
        }
        
        [DataTestMethod]
        [DataRow(1,2,3)]
        [DataRow(1, 3, 4)]
        [DataRow(1, 4, 5)]
    }
}