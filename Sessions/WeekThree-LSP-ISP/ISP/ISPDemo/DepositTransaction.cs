
namespace ISPDemo
{
    public class DepositTransaction : Transaction
    {
        private IDepositUI _depositUI;

        public DepositTransaction(IDepositUI depositUI)
        {
            _depositUI = depositUI;
        }

        public override void Execute()
        {
            _depositUI.RequestDepositAmount();
        }
    }

    public class WithdrawlTransaction : Transaction
    {
        private IWithdrawlUI _withdrawlUI;

        public WithdrawlTransaction(IWithdrawlUI withdrawlUI)
        {
            _withdrawlUI = withdrawlUI;
        }

        public override void Execute()
        {
            _withdrawlUI.RequestWithdrawlAmount();
        }

    }
}