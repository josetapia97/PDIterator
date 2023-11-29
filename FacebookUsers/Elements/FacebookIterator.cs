using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookUsers.Elements
{
    public class FacebookIterator : IFacebookIterator<User>
    {
        private List<User> _users;
        private int _position;
        public FacebookIterator(List<User> users)
        {
            _users = users;
        }
        public User CurrentUser()
        {
            return _users[_position];
        }

        public bool HasNextUser()
        {
            return _position < _users.Count ;
        }

        public User NextUser()
        {
            var user = _users[_position];
            _position++;
            return user;
        }
    }
}
