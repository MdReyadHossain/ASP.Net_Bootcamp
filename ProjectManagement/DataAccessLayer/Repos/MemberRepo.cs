using DataAccessLayer.Interface;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repos
{
    public class MemberRepo : Repo, IMember<Member, int, bool>
    {
        public bool Create(Member obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Member> Get()
        {
            throw new NotImplementedException();
        }

        public Member Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Member obj)
        {
            throw new NotImplementedException();
        }
    }
}
