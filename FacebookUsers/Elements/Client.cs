using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookUsers.Elements
{
    public class Client
    {
        public void ShowUsers(ICollection<User> collection)
        {
            var iterador = collection.CreateIterator();
            while(iterador.HasNextUser())
            {
                var user = iterador.NextUser();
                Console.WriteLine(user.name);
            }
        }
    }
}
