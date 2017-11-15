using FunctionalCurry.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalCurry.Oops
{
    public interface INotificationService
    {

        Outcome SendNotification(UserInfo userInfo);
    }
}
