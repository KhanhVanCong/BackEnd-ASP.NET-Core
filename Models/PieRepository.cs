using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practive_shop.Models
{
    public class PieRepository: IPieRespository
    {
        private readonly AppDbContext _appDbContext;


        public PieRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Pie> GetAllPie()
        {
            return _appDbContext.Pies;
        }

        public Pie GetPieById(int pieId)
        {
            return _appDbContext.Pies.FirstOrDefault(p => p.Id == pieId);
        }
    }
}
