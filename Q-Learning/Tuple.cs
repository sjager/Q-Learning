using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_Learning
{
    public class Tuple
    {
        public string currentState;
        public string action;
        public string nextState;

        public override bool Equals(object obj)
        {
            Tuple tuple = obj as Tuple;

            if (tuple == null)
            {
                return false;
            }
            if (tuple.currentState.Equals(this.currentState) && tuple.action.Equals(this.action) && tuple.nextState.Equals(this.nextState))
            {
                return true;
            }
            else
            {
                return false;
            }
                
        }
    }
}
