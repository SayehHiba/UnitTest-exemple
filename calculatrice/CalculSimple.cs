using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatrice
{
    public class CalculSimple
    {

        #region data
        private double _memo;
        private IAuthentification _authentifier;
        private int mot;
        #endregion

        #region Propriétés
        double Memo
        {
            get { return _memo; }
            set { _memo = value; }
        }

        public IAuthentification Authentifier
        {
            get { return _authentifier; }
            set { _authentifier = value; }
        }
        #endregion

        #region Constructeur
        public  CalculSimple()
        {
            _memo=0;
            _authentifier = null;
        }
        #endregion

        #region methodes
        public double Addition(double x, double y){
            if (!_authentifier.Authentifier) throw new ArgumentException("Erreur d'autentification");
            if (x <= double.MinValue || y<= double.MinValue) 
                throw new ArgumentException("opérande inférieure à la limite" + x + y );
            _memo = x+y;
            return _memo;
        }
        public double Soustraction(double x, double y)
        {
            if (!_authentifier.Authentifier) throw new ArgumentException("Erreur d'autentification");
            _memo = x - y;
            return _memo;
        }
        public double Multiplication(double x, double y)
        {
           // if (!_authentifier.Authentifier) throw new ArgumentException("Erreur d'autentification");
            _memo = x * y;
            return _memo;
        }
        public double Division(double x, double  y)
        {
            //if (!_authentifier.Authentifier) throw new ArgumentException("Erreur d'autentification");
            if (y==null || y == 0)
            {
                throw new ArgumentException("Erreur Division par Zero");
            }
            else
            {
                _memo = x / y;
                return _memo;
            }
            
        }
        #endregion
    }
}
