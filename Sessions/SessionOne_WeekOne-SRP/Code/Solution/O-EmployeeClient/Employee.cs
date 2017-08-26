using System;

namespace O_EmployeeClient
{
    public abstract class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfJoining { get; set; }
        public Decimal Utilization { get; set; }
        public ConsultantType ConsultantType { get; set; }
    }
}