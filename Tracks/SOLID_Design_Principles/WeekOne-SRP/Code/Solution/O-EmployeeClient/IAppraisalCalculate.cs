using System;
using System.Collections.Generic;
using System.Text;

namespace O_EmployeeClient
{
    public interface IAppraisalCalculate
    {
        bool Rule(string ruleName);

        double IncrementAmount();
    }
}
