using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    public interface IProject<TYPE, ID, ST, RET>
    {
        List<TYPE> Get();
        TYPE Get(ID id);
        TYPE Get(ST status);
        RET Create(TYPE obj);
        RET Update(TYPE obj);
        bool Delete(ID id);
    }
}
