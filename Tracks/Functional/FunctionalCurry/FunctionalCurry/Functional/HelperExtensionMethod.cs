using FunctionalCurry.Common;
using System;

namespace FunctionalCurry.Functional
{
    public static class HelperExtensionMethod
    {

        public static Outcome  SendNotification(this UserInfo userInfo, Func<UserInfo,Outcome> notification )
        {
            if(userInfo !=null)
            {
                return notification(userInfo);
            }
            else
            {
               return Outcome.Fail("invalid data");
            }
        }

        public static Outcome SendNotification(this Outcome<UserInfo> outcome, Func<UserInfo, Outcome> notification)
        {
            if (outcome != null)
            {
                return notification(outcome.Data);
            }
            else
            {
                return Outcome.Fail("invalid result");
            }
        }

        private static Outcome SendNotification<T>(this Outcome<T> outCome, Func<UserInfo, Outcome> notification)
        {
            if (outCome == null)
            {
                return Outcome.Fail( "invalid data");
            }
            else
            {
                if(outCome.IsSuccess)
                {

                }
                return  Outcome.Fail( "invalid data");
            }
        }


        public static Outcome<UserInfo> GetUser<UserInfo>(this IUserProvider userProvider,int userId)
        {
            if (userProvider == null)
            {               
                return Outcome<UserInfo>.Fail<UserInfo>("invalid provider");
            }
            else
            {               
                var  data= userProvider.GetUserById(userId);
                return data != null ? Outcome<UserInfo>.Ok<UserInfo>(data) : Outcome<UserInfo>.Fail<UserInfo>("failt to get userinfo");
            }
        }
    }
}
