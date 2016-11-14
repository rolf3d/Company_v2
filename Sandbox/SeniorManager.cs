using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class SeniorManager : Manager
    {
        private int _performancelevel;
        public SeniorManager(string name, int performancelevel) : base(name)
        {
            this._performancelevel = performancelevel;
        }

        public override bool IsBonusPaidOut()
        {
            if (_performancelevel >= 6)
            {
                return true;
            }

            return false;
        }
    }
}
