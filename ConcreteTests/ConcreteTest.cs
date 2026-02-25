using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidtermQ1;

namespace ConcreteTests
{
    public class ConcreteTest
    {
        //New Residential Test
        [Test]
        public void CalculateCost_NewResidential1SquareMeter_Returns20()
        {
            //Arrange
            double expected = 20;

            //Act
            double actual = ConcreteCostCalculator.CalculateCost(CustomerType.NewResidential, 1);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        //Existing Residential Test
        [Test]
        public void CalculateCost_ExistingResidential1SquareMeter_Returns15()
        {
            //Arrange
            double expected = 15;

            //Act
            double actual = ConcreteCostCalculator.CalculateCost(CustomerType.ExistingResidential, 1);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        //Commercial Test
        [Test]
        public void CalculateCost_Commercial1SquareMeter_Returns10()
        {
            //Arrange
            double expected = 10;

            //Act
            double actual = ConcreteCostCalculator.CalculateCost(CustomerType.Commercial, 1);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        //Upper Boundary Test (10 sqm)
        [Test]
        public void CalculateCost_Commericial10SquareMeters_Return100()
        {
            //Arrange
            double expected = 100;

            //Act
            double actual = ConcreteCostCalculator.CalculateCost(CustomerType.Commercial, 10);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        //Above Upper Boundary Test (11 sqm)
        [Test]
        public void CalculateCost_Commericial11SquareMeters_ReturnNegative2()
        {
            //Arrange
            double expected = -2;

            //Act
            double actual = ConcreteCostCalculator.CalculateCost(CustomerType.Commercial, 11);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
