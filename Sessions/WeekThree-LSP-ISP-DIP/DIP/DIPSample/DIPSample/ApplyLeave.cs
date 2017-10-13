using System;
namespace DIPSample
{
    public class ApplyLeave
    {
		//public void InformEarnedLeave()
		//{
  //          EarnedLeave earnerLeave = new EarnedLeave();
		//    earnerLeave.Inform();
		//}

		//public void InformCasualLeave()
		//{
  //            CasualLeave casualLeave = new CasualLeave();
  //            casualLeave.Inform();
		//}


		//TODO: Uncomment for solution demo.

		private IInform _inform;

		public ApplyLeave(IInform inform)
		{
		    _inform = inform;
		}

		public void InformLaveType()
		{
		    _inform.Inform();
		}
	}
}
