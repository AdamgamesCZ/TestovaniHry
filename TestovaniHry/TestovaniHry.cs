using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Hra;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;

namespace TestovaniHry
{
    [TestClass]
    public class TestovaniHry
    {
        Testos test = new Hra.Testos();
        [TestMethod]
        public void jeDelkaJmena()
        {

            Assert.IsTrue(test.jmeno.Length < 10);



        }
        [TestMethod]
        public void maJmeno()
        {

            Assert.IsTrue(test.jmeno.Length < 0);



        }
        [TestMethod]
        public void jeEnumOblicej()
        {

            Assert.IsTrue(test.oblicej == "velký nos" || test.oblicej == "ušoplesk" || test.oblicej == "make-up");



        }
        [TestMethod]
        public void jsouEnumVlasy()
        {
            Assert.IsTrue(test.vlasy == "drdol" || test.vlasy == "culík" || test.vlasy == "pleška(bulant)");

        }
        [TestMethod]
        public void jsouEnumBarvaVlasy()
        {
            Assert.IsTrue(test.barvaVlasy == "kaštanová" || test.barvaVlasy == "blond" || test.barvaVlasy == "červená");

        }
        [TestMethod]
        public void jeLevel()
        {
            Assert.AreEqual(test.level, 1);

        }
        [TestMethod]
        public void neniLevelNula()
        {
            Assert.AreEqual(!test.level, 0);

        }
        [TestMethod]
        public void jePoziceX()
        {
            Assert.AreEqual(test.PosX, 0);

        }
        [TestMethod]
        public void jeSpatneNastavenaPoziceX()
        {
            Assert.AreEqual(!test.PosX, 0);

        }
        [TestMethod]
        public void jePoziceY()
        {
            Assert.AreEqual(test.PosY, 0);

        }
        [TestMethod]
        public void jeOblicej()
        {

            Assert.AreEqual(test.oblicej, 0);

        }
        [TestMethod]
        public void jeSpecializace()
        {

            Assert.IsTrue(test.specializace == "Kouzelník" || test.specializace == "Berserker" || test.specializace == "Inženýr" || test.specializace == "Cizák");

        }
        [TestMethod]
        public void jsouVlasy()
        {
            Assert.AreEqual(test.vlasy, 0);

        }
        [TestMethod]
        public void jeBarvaVlasu()
        {
            Assert.AreEqual(test.barvaVlasu, 0);

        }
        [TestMethod]
        public void jeXP()
        {
            Assert.AreEqual(test.XP, 0);

        }
        [TestMethod]
        public void maMocXP()
        {
            Assert.AreEqual(test.XP > 0);

        }
        [TestMethod]
        public void jePrace()
        {
            Assert.IsTrue(test.prace == "obchodník" || test.specializace == "nepřítel" || test.specializace == "obyvatel");

        }
        [TestMethod]
        public void jeNezamestnany()
        {
            Assert.IsTrue(test.prace == string.Empty);

        }
        [TestMethod]
        public void jeSila()
        {
            Assert.IsTrue(test.sila >= 100);

        }
        [TestMethod]
        public void jeSlaboch()
        {
            Assert.IsTrue(test.sila <= 100);

        }

    }
}



    

