using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookUsers.Elements
{
    public class UserCollection : ICollection<User>
    {
        private List<User> _users;
        public UserCollection(List<User> users)
        {
            _users = users;
        }
        public IFacebookIterator<User> CreateIterator()
        {
            return new FacebookIterator(_users);
        }
    }
}
