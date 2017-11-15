using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalCurry.Common
{
    public class UserProvider : IUserProvider
    {
        /// <summary>
        /// in production code you may have to inject dbContext
        /// </summary>
        public UserProvider()
        {

        }
        public UserInfo GetUserById(int userId)
        {

            // record query from database (using db context);
            return new UserInfo()
            {
                EmailId = "divyang.panchasara@neudesic.com",
                FirstName = "Divyang",
                LastName = "Panchasara",
                PhoneNumber = "+919723822403",
                UserId = userId
            };
        }
    }
}
