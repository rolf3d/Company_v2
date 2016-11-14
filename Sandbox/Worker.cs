using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Worker : Employee
    {

        private int _hourlypay;
        private int _hoursworked;
        public Worker(string name) : base(name)
        {
            _hoursworked = 180;
            _hourlypay = 220;
        }

        public override int GetSalaryPerMonth()
        {
            return _hoursworked *_hourlypay;
        }

        public override int GetBonusPerMonth()
        {
            return 0;
        }

        public override bool IsBonusPaidOut()
        {
            return false;
        }
    }
}
