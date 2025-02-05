using Microsoft.VisualStudio.TestTools.UnitTesting;
using Module3AnimalKingdomVER2;

namespace AnimalTests
{
    [TestClass]
    public class AnimalInheritanceTests
    {
        [TestMethod]
        public void Bird_MakeSound_ReturnsCorrectSound()
        {
            // Arrange
            var bird = new Bird("Macaw", 6);
            var expectedSound = "Macaw chirps.";

            // Act
            using var sw = new StringWriter();
            Console.SetOut(sw);
            bird.MakeSound();

            // Assert
            var result = sw.ToString().Trim();
            Assert.AreEqual(expectedSound, result);
        }

        [TestMethod]
        public void Fish_MakeSound_ReturnsCorrectSound()
        {
            // Arrange
            var fish = new Fish("Tuna", 1);
            var expectedSound = "Tuna bubbles.";

            // Act
            using var sw = new StringWriter();
            Console.SetOut(sw);
            fish.MakeSound();

            // Assert
            var result = sw.ToString().Trim();
            Assert.AreEqual(expectedSound, result);
        }

        [TestMethod]
        public void Bird_InitializedWithCorrectValues()
        {
            // Arrange
            var bird = new Bird("Macaw", 6);

            // Act & Assert
            Assert.AreEqual("Macaw", bird.Name);
            Assert.AreEqual(6, bird.Age);
        }

        [TestMethod]
        public void Fish_InitializedWithCorrectValues()
        {
            // Arrange
            var fish = new Fish("Tuna", 1);

            // Act & Assert
            Assert.AreEqual("Tuna", fish.Name);
            Assert.AreEqual(1, fish.Age);
        }
    }
}