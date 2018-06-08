using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace Patterns.Ex02
{
    public abstract class AnyUserService<T>
    {
        protected abstract UserInfo[] ConvertToUserInfo(T[] user);
        protected abstract string Parse(string pageUrl);

        public UserInfo GetUserInfo(string pageUrl)
        {
            var userId = Parse(pageUrl);
            var users = GetFriendsById(userId);
            UserInfo result = new UserInfo
            {
                UserId = userId,
                Name = GetName(userId),              
                Friends = ConvertToUserInfo(users)
            };

            return result;
        }

        protected abstract string GetName(string userId);
        protected abstract T[] GetFriendsById(string userId);
    }
}
