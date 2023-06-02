using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MathLibrary;

namespace UnitTestProject
{
    [TestClass]
    public class GeometryUnitTest
    {
        [TestMethod]
        public void TestMethodSTrianglea2h4c4()
        {
            //Arrange

            double a = 2;
            double h = 4;
            double c = 4;

            //Act

            double res = Geometry.STriangle(a, h);

            //Assert
            Assert.AreEqual(c, res);
        }

        [TestMethod]
        public void TestMethodSTrianglea6h5c15()
        {
            //Arrange

            double a = 6;
            double h = 5;
            double c = 15;

            //Act

            double res = Geometry.STriangle(a, h);

            //Assert
            Assert.AreEqual(c, res);
        }

        [TestMethod]
        public void TestMethodSTrianglea1dot5h2c1dot5()
        {
            //Arrange

            double a = 1.5;
            double h = 2;
            double c = 1.5;

            //Act

            double res = Geometry.STriangle(a, h);

            //Assert
            Assert.AreEqual(c, res);
        }

        [TestMethod]
        public void SRTrianglea6b4c12()
        {
            //Arrange

            double a = 6;
            double b = 4;
            double c = 12;

            //Act

            double res = Geometry.SRTriangle(a, b);

            //Assert
            Assert.AreEqual(c, res);
        }

        [TestMethod]
        public void SRTrianglea10b2c10()
        {
            //Arrange

            double a = 10;
            double b = 2;
            double c = 10;

            //Act

            double res = Geometry.SRTriangle(a, b);

            //Assert
            Assert.AreEqual(c, res);
        }

        [TestMethod]
        public void SRTrianglea5b8c16()
        {
            //Arrange

            double a = 4;
            double b = 8;
            double c = 16;

            //Act

            double res = Geometry.SRTriangle(a, b);

            //Assert
            Assert.AreEqual(c, res);
        }

        [TestMethod]
        public void SRectanglea20b4c80()
        {
            //Arrange

            double a = 20;
            double b = 4;
            double c = 80;

            //Act

            double res = Geometry.SRectangle(a, b);

            //Assert
            Assert.AreEqual(c, res);
        }

        [TestMethod]
        public void SRectanglea5b2c10()
        {
            //Arrange

            double a = 5;
            double b = 2;
            double c = 10;

            //Act

            double res = Geometry.SRectangle(a, b);

            //Assert
            Assert.AreEqual(c, res);
        }

        [TestMethod]
        public void SRectanglea15b3c45()
        {
            //Arrange

            double a = 15;
            double b = 3;
            double c = 45;

            //Act

            double res = Geometry.SRectangle(a, b);

            //Assert
            Assert.AreEqual(c, res);
        }

        [TestMethod]
        public void SCircler2s12dot56()
        {
            //Arrange

            double r = 2;
            double s = 12.56;

            //Act

            double res = Geometry.SCircle(r);

            //Assert
            Assert.AreEqual(s, res);
        }

        [TestMethod]
        public void SCircler9s254dot46()
        {
            //Arrange

            double r = 9;
            double s = 254.34;

            //Act

            double res = Geometry.SCircle(r);

            //Assert
            Assert.AreEqual(s, res);
        }

        [TestMethod]
        public void SCircler2s78dot53()
        {
            //Arrange

            double r = 5;
            double s = 78.5;

            //Act

            double res = Geometry.SCircle(r);

            //Assert
            Assert.AreEqual(s, res);
        }

        [TestMethod]

        public void STrapezea2b4h2s6()
        {
            //Arrange

            double a = 2;
            double b = 4;
            double h = 2;
            double s = 6;

            //Act

            double res = Geometry.STrapeze(a,b,h);

            //Assert
            Assert.AreEqual(s, res);
        }

        [TestMethod]

        public void STrapezea6b2h9s36()
        {
            //Arrange

            double a = 6;
            double b = 2;
            double h = 9;
            double s = 36;

            //Act

            double res = Geometry.STrapeze(a, b, h);

            //Assert
            Assert.AreEqual(s, res);
        }

        [TestMethod]

        public void STrapezea8b26h5s85()
        {
            //Arrange

            double a = 8;
            double b = 26;
            double h = 5;
            double s = 85;

            //Act

            double res = Geometry.STrapeze(a, b, h);

            //Assert
            Assert.AreEqual(s, res);
        }


    }
}
