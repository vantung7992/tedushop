using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Model.Models;
using TeduShop.Data.Infastructure;

namespace TeduShop.Data.Repositories
{
    public interface IVisitorStatisticRepository : IRepository<VisitorStatistic> { }
    class VisitorStatisticRepository : RepositoryBase<VisitorStatistic>, IVisitorStatisticRepository
    {
        public VisitorStatisticRepository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}
