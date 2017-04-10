using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IErrorRepository : IRepository<Errors>
    { }
    public class ErrorRepository : RepositoryBase<Errors>, IErrorRepository
    {
        public ErrorRepository(IDbFactory dbFactory) : base(dbFactory)
        { }
    }
}
