

using System;
using NUnit.Framework;
using calculatrice;


namespace UnitTestCalculatrice
{
    [TestFixture]
    public class UnitTestCalculSimple
    {
        CalculSimple cs;
        [SetUp]
        public void setup()
        {
            cs = new CalculSimple();
            IAuthentification StubAthentification = new FakeAuthentification();  // stub Authentification
            cs.Authentifier = StubAthentification;
            cs.Authentifier.Verifier("x", "y");
        }

        [TestCase(double.MinValue,0)]
        [TestCase(double.MinValue,double.MinValue)]
        [TestCase(0,double.MinValue)]
        [TestCase(double.MinValue-1,0)]
        [TestCase(double.MinValue-1,double.MinValue-1)]
        [TestCase(0,double.MinValue-1)]
        public void Addition_UneOperandeEnLimitInf_Exception(double x,double y)
        {
            var resultat = Assert.Catch<ArgumentException>(()=> cs.Addition(x,y));
            Assert.That(resultat.Message ,Is.StringContaining("inférieure"));
           // StringAssert.Contains( "inférieure",resultat.Message);
   
        }

        

        [Test]
        [Ignore ("Obsolète")]
        public void Division_Operande2Zero_Zero()
        {
            
            Assert.AreEqual(0, cs.Division(5, 0));
        }

        
        [TestCase (0)]
        [TestCase (null)]
        public void Division_DiviseurNullOuZero_Exception(double y)
        {
            
            var ex = Assert.Catch<ArgumentException>(()=>cs.Division(5, y));
            Assert.That(ex.Message, Is.StringContaining("Erreur Division par Zero"));
            //StringAssert.Contains("Erreur Division par Zero", ex.Message);
        }
    }

    public class FakeAuthentification : IAuthentification
    {
        #region Data
        bool _authentifier;
        #endregion
        #region Propriétés
        public bool Authentifier
        {
            get { return _authentifier; }
            set { _authentifier = value; }
        }
        #endregion
        public FakeAuthentification() { }

        public bool Verifier(string nom, string motPasse)
        {  
            _authentifier = true;
            return _authentifier;

        }
    }
}
