namespace FunctionalCurry.Common
{
    public interface IUserProvider
    {

        UserInfo GetUserById(int userId);
    }
}
