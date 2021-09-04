using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatrice
{
    /// <summary>
    /// fonction de suite d'opération mathématique
    /// </summary>
    class ExpressionMathematique
    {
        Queue<CalculSimple> file;
        public ExpressionMathematique()
        {
            // init la file d'attente
            file = new Queue<CalculSimple>(100);
        }
        public void AjouterExpression(CalculSimple expression)
        {   
            file.Enqueue(expression);
        }
        public void TraiterOperation()
        {

        }
        public void EvaluerExpression()
        {

        }


    }
}
