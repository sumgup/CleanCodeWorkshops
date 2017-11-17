using FunctionalCurry.Common;

namespace FunctionalCurry.Oops
{
    public interface INotificationService
    {

        Outcome SendNotification(UserInfo userInfo);
    }
}
