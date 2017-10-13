using System;

namespace DIPSample
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ApplyLeave applyLeave = new ApplyLeave(new CasualLeave());

            applyLeave.InformLaveType();

            new ApplyLeave(new EarnedLeave()).InformLaveType();
        }
    }
}
