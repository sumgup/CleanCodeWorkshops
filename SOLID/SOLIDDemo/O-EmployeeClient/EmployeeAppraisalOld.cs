using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace O_EmployeeClient
{
    public class EmployeeAppraisalOld        
    {
        public bool CanAppraiseEmployee(Employee employee, string ruleName)
        {
            bool canAppraiseEmployee = false;

            // RULE - 1  Appraise only if employee is 100 days old or greater
            if (ruleName == "EmployeeDuration")
            {
                canAppraiseEmployee = true;
            }

            // RULE - 2 Should have 75% or greater utilization
            else if (ruleName == "Utilization")
            {
                canAppraiseEmployee = true;
            }

            // RULE - 3 - I want to appraise 
            else if (ruleName == "ConsultantType")
            {
                canAppraiseEmployee = true;
            }
         
            return canAppraiseEmployee;
        }

    }
}
