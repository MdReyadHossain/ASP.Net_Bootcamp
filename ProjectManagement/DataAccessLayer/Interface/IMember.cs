using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    public interface IMember<TYPE, ID, RET>
    {
        List<TYPE> Get();
        TYPE Get(ID id);
        RET Create(TYPE obj);
        RET Update(TYPE obj);
        bool Delete(ID id);
    }
}
