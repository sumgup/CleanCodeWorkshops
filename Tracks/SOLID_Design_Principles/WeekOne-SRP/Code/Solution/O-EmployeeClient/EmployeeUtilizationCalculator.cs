using System;
using System.Collections.Generic;
using System.Text;

namespace O_EmployeeClient
{
    public class EmployeeUtilizationCalculator : IAppraisalCalculate
    {
        public bool Rule(string ruleName)
        {
            return "EmployeeUtilization".Equals(ruleName);
        }

        public double IncrementAmount()
        {  
            return 20;
        }
    }
}
