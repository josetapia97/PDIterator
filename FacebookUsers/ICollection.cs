using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookUsers
{
    public interface ICollection<T>
    {
        IFacebookIterator<T> CreateIterator();
    }
}
