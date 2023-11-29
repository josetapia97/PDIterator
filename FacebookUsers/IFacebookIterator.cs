using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookUsers
{
    public interface IFacebookIterator<T>
    {
        T CurrentUser();
        bool HasNextUser();
        T NextUser();
    }
}
