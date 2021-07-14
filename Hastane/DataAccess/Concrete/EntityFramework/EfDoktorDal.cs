using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDoktorDal : EfEntityRepositoryBase<Doktor, HastaneContext>, IDoktorDal
    {
        
    }
}
