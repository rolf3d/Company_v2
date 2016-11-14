using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class JuniorManager : Manager
    {
        private int _hoursworked { get; set; }
        public JuniorManager(string name, int hoursworked) : base(name)
        {
            this._hoursworked = hoursworked;
        }
        

        public override bool IsBonusPaidOut()
        {
            if (_hoursworked >= 180)
            {
                return true;
            }

            return false; 
        }


    }
}
