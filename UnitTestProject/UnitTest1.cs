using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ubots.Negocio;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ExisteCliente()
        {

            string cpf = "00000000002";

            var cliente = ClienteNeg.Buscar(cpf);

            // Assert
            Assert.IsNotNull(cliente.id);
        }

        [TestMethod]
        public void ClienteNaoExiste()
        {

            string cpf = "00000000011";

            var cliente = ClienteNeg.Buscar(cpf);

            // Assert
            Assert.AreEqual(0, cliente.id);
        }

    }
}
