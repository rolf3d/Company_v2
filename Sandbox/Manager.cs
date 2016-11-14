using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    abstract class Manager : Employee
    {
        private int _monthlybasesalary;
        private  int _monthlybonus;
        public Manager(string name) : base(name)
        {
            _monthlybasesalary = 80000;
            _monthlybonus = 40000;
        }

        public override int GetSalaryPerMonth()
        {
            return _monthlybasesalary;
        }

        public override int GetBonusPerMonth()
        {
            return _monthlybonus;
        }

        public override bool IsBonusPaidOut()
        {
            throw new NotImplementedException();
        }
    }
}
