
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MathLibrary;

namespace UnitTestProject
{

    [TestClass]
    public class TrigonometryUnitTest
    {

        [TestMethod]
        public void SinAac8ab4s2()
        {
            //Arrange

            double ac = 8;
            double ab = 4;
            double s = 2;

            //Act

            double res = Trigonometry.SinA(ac, ab);

            //Assert
            Assert.AreEqual(s, res);
        }

        [TestMethod]
        public void SinAac10ab8s0dot8()
        {
            //Arrange

            double ac = 10;
            double ab = 8;
            double s = 1.25;

            //Act

            double res = Trigonometry.SinA(ac, ab);

            //Assert
            Assert.AreEqual(s, res);
        }

        [TestMethod]
        public void SinAac25ab5s5()
        {
            //Arrange

            double ac = 25;
            double ab = 5;
            double s = 5;

            //Act

            double res = Trigonometry.SinA(ac, ab);

            //Assert
            Assert.AreEqual(s, res);
        }

        [TestMethod]
        public void CosAbc10ab2s5()
        {
            //Arrange

            double bc = 10;
            double ab = 2;
            double s = 5;

            //Act

            double res = Trigonometry.CosA(bc, ab);

            //Assert
            Assert.AreEqual(s, res);
        }

        [TestMethod]
        public void CosAbc6ab2s3()
        {
            //Arrange

            double bc = 6;
            double ab = 2;
            double s = 3;

            //Act

            double res = Trigonometry.CosA(bc, ab);

            //Assert
            Assert.AreEqual(s, res);
        }

        [TestMethod]
        public void CosAbc18ab6s3()
        {
            //Arrange

            double bc = 18;
            double ab = 6;
            double s = 3;

            //Act

            double res = Trigonometry.CosA(bc, ab);

            //Assert
            Assert.AreEqual(s, res);
        }

        [TestMethod]
        public void TgAac10bc2s5()
        {
            //Arrange

            double ac = 50;
            double bc = 2;
            double s = 25;

            //Act

            double res = Trigonometry.TgA(ac, bc);

            //Assert
            Assert.AreEqual(s, res);
        }

        [TestMethod]
        public void TgAac100bc2s50()
        {
            //Arrange

            double ac = 100;
            double bc = 2;
            double s = 50;

            //Act

            double res = Trigonometry.TgA(ac, bc);

            //Assert
            Assert.AreEqual(s, res);
        }

        [TestMethod]
        public void TgAac30bc10s3()
        {
            //Arrange

            double ac = 30;
            double bc = 10;
            double s = 3;

            //Act

            double res = Trigonometry.TgA(ac, bc);

            //Assert
            Assert.AreEqual(s, res);
        }

        [TestMethod]
        public void CtgAbc30ac10s3()
        {
            //Arrange

            double bc = 80;
            double ac = 4;
            double s = 20;

            //Act

            double res = Trigonometry.CtgA(bc, ac);

            //Assert
            Assert.AreEqual(s, res);
        }

        [TestMethod]
        public void CtgAbc24ac6s4()
        {
            //Arrange

            double bc = 24;
            double ac = 6;
            double s = 4;

            //Act

            double res = Trigonometry.CtgA(bc, ac);

            //Assert
            Assert.AreEqual(s, res);
        }

        [TestMethod]
        public void CtgAbc22ac2s11()
        {
            //Arrange

            double bc = 22;
            double ac = 2;
            double s = 11;

            //Act

            double res = Trigonometry.CtgA(bc, ac);

            //Assert
            Assert.AreEqual(s, res);
        }

        [TestMethod]
        public void ArcSinAx()
        {
            //Arrange

            double x = 0;
            double s = 0;

            //Act

            double res = Trigonometry.ArcSinA(x);

            //Assert
            Assert.AreEqual(s, res);
        }

        [TestMethod]
        public void ArcSinAx0()
        {
            //Arrange

            double x = 0;
            double s = 0;

            //Act

            double res = Trigonometry.ArcSinA(x);

            //Assert
            Assert.AreEqual(s, res);
        }

    }
}