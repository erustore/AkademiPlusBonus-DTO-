using AkademiPlusBonusDataAccessLayer.Abstract;
using AkademiPlusBonusDataAccessLayer.Repositories;
using AkademiPlusBonusEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlusBonusDataAccessLayer.EntityFramework
{
    public class EfCategoryDal:GenericRepository<Category>,ICategoryDal
    {
    }
}
