using DesafioPOO.Models;
using NUnit.Framework;

namespace DesafioPOO.Tests
{
    [TestFixture]
    public class SmartphoneTests
    {
        [Test]
        public void TestNokiaLigar()
        {
            // Arrange
            Nokia nokia = new Nokia("+5511912341234", "Show do Milhão", 102768022082308, 256);

            // Act
            nokia.Ligar();

            // Assert
            Assert.AreEqual("Ligando...", Console.Out.ToString().Trim());
        }

        [Test]
        public void TestNokiaReceberLigacao()
        {
            // Arrange
            Nokia nokia = new Nokia("+5511912341234", "Show do Milhão", 102768022082308, 256);

            // Act
            nokia.ReceberLigacao();

            // Assert
            Assert.AreEqual("Recebendo ligação...", Console.Out.ToString().Trim());
        }

        [Test]
        public void TestNokiaInstalarAplicativo()
        {
            // Arrange
            Nokia nokia = new Nokia("+5511912341234", "Show do Milhão", 102768022082308, 256);

            // Act
            nokia.InstalarAplicativo("Amazon");

            // Assert
            Assert.AreEqual("Instalando Amazon em um Nokia", Console.Out.ToString().Trim());
        }

        [Test]
        public void TestIphoneLigar()
        {
            // Arrange
            Iphone iphone = new Iphone("+5511925254646", "Iphone 13 pro", 915019261710788, 512);

            // Act
            iphone.Ligar();

            // Assert
            Assert.AreEqual("Ligando...", Console.Out.ToString().Trim());
        }

        [Test]
        public void TestIphoneReceberLigacao()
        {
            // Arrange
            Iphone iphone = new Iphone("+5511925254646", "Iphone 13 pro", 915019261710788, 512);

            // Act
            iphone.ReceberLigacao();

            // Assert
            Assert.AreEqual("Recebendo ligação...", Console.Out.ToString().Trim());
        }

        [Test]
        public void TestIphoneInstalarAplicativo()
        {
            // Arrange
            Iphone iphone = new Iphone("+5511925254646", "Iphone 13 pro", 915019261710788, 512);

            // Act
            iphone.InstalarAplicativo("Netflix");

            // Assert
            Assert.AreEqual("Instalando Netflix em um Iphone", Console.Out.ToString().Trim());
        }
    }

    internal class TestFixtureAttribute : Attribute
    {
    }
}
