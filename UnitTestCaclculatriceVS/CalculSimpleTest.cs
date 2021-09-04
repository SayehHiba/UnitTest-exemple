using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using calculatrice;

namespace UnitTestCaclculatriceVS
{
    [TestClass]
    public class CalculSimpleTest
    {
        [TestMethod]
        public void Addition_ParametresZero_ReturnZero()
        {
            //Arrange
            CalculSimple cs = new CalculSimple();
            cs.Authentifier = new Authentification(); 
            cs.Authentifier.Verifier("salah", "ali"); // ceci n'est pas correct pour un test unitaire!!!!!
            //Act
            var resultat = cs.Addition(0, 0);
            //Assert
            Assert.AreEqual(resultat, 0);
        }
        [TestMethod]
        public void Addition_ParametresEntier_ReturnEntier()
        {
            //Arrange
            CalculSimple cs = new CalculSimple();
            cs.Authentifier = new Authentification();
            cs.Authentifier.Verifier("salah", "ali");
            //Act
            var resultat = cs.Addition(5, 4);
            //Assert
            Assert.AreEqual(resultat, 9);
        }
    }
}
