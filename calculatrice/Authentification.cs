using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatrice
{

    public interface IAuthentification
    {
        bool Authentifier
        {
            get ;
            set ;
        }
         bool Verifier(string nom, string motPasse);

    }
    
    public class Authentification : IAuthentification
    {
        #region Data
        private bool _authentifier;
        #endregion
        #region Propriétés
        public bool Authentifier
        {
            get { return _authentifier; }
            set { _authentifier = value; }
        }
        #endregion
        public Authentification() { }
        
        public bool Verifier(string nom, string motPasse){

            // accéder à la base de données

            //vérifier l'existance

            //vérfifier le mot de passe

            // si correct retourner true sinon false
            Authentifier = true;
            return Authentifier;

        }
    }
}
