using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace O_EmployeeClient
{
    public class EmployeeAppraisalOldOld        
    {
        public bool CanAppraiseEmployee(Employee employee)
        {
            bool canAppraiseEmployee = false;

            // RULE - 1  Appraise only if employee is 100 days old or greater
            if (DateTime.Compare(employee.DateOfJoining, DateTime.Now) > 100)
            {
                canAppraiseEmployee = true;
            }

            // RULE - 2 Should have 75% or greater utilization
            if (employee.Utilization >= 75)
            {
                canAppraiseEmployee = true;
            }

            // RULE - 3 - I want to appraise 
            if (employee.ConsultantType == ConsultantType.Consultant)
            {
                canAppraiseEmployee = true;
            }
            
         
            return canAppraiseEmployee;
        }

        public bool CanAppraiseEmployeeWithExcludedList(Employee employee, List<Employee> employeeIdsToExclude)
        {
            bool canAppraiseEmployee = false;

            // RULE - 1  Appraise only if employee is 100 days old or greater
            if (DateTime.Compare(employee.DateOfJoining, DateTime.Now) > 100)
            {
                canAppraiseEmployee = true;
            }

            // RULE - 2 Should have 75% or greater utilization
            if (employee.Utilization >= 75)
            {
                canAppraiseEmployee = true;
            }

            // RULE - 3 - I want to appraise 
            if (employee.ConsultantType == ConsultantType.Consultant)
            {
                canAppraiseEmployee = true;
            }

            // RULE 4 - If Employee exists in Excluded List than can not appraise
            if (employeeIdsToExclude.FirstOrDefault(e => e.EmployeeId == employee.EmployeeId) != null)
            {
                canAppraiseEmployee = false;
            }

            return canAppraiseEmployee;
        }
    }
}
