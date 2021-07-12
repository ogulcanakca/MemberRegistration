using MemberRegistration.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELibrary.Library.Core.DataAccess;

namespace MemberRegistration.DataAccess.Abstract
{
    public interface IMemberDal : IEntityRepository<Member>
    {
    }
}
