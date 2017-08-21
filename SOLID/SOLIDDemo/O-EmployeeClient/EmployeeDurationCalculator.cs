using System;
using System.Collections.Generic;
using System.Text;

namespace O_EmployeeClient
{
    public class EmployeeDurationCalculator : IAppraisalCalculate
    {
        public bool Rule(string ruleName)
        {
            return "EmployeeDuration".Equals(ruleName);
        }

        public double IncrementAmount()
        {
            return 20;
        }
    }
}
