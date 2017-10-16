using Microsoft.VisualStudio.TestTools.UnitTesting;
using VehicleBuilder.Director;
using VehicleBuilder.ConcreteBuilder;

namespace VehicleBuilder.UnitTest
{
    [TestClass]
    public class VehicleCreationTests
    {
        [TestMethod]
        public void CreateHeroVehicle()
        {
            //Arrange
            var heroCreator = new VehicleCreator(new HeroBuilder());
            heroCreator.CreateVehicle();

            //Act
            var heroVehicle = heroCreator.GetVehicle();
            heroVehicle.ShowInfo();

            //Assert
            Assert.AreEqual("Plastic", heroVehicle.Body);
        }

        [TestMethod]
        public void CreateHondaVehicle()
        {
            //Arrange
            var hondaCreator = new VehicleCreator(new HondaBuilder());
            hondaCreator.CreateVehicle();

            //Act
            var hondaVehicle = hondaCreator.GetVehicle();
            hondaVehicle.ShowInfo();

            //Assert
            Assert.AreEqual("Honda", hondaVehicle.Model);
        }

        [TestMethod]
        public void CreateBajajVehicle()
        {
            //Arrange
            var bajajCreator = new VehicleCreator(new BajajBuilder());
            bajajCreator.CreateVehicle();

            //Act
            var bajajVehicle = bajajCreator.GetVehicle();
            bajajVehicle.ShowInfo();

            //Assert
            Assert.AreEqual("150KMPH", bajajVehicle.Transmission);

        }

    }
}
