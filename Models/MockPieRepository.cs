using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practive_shop.Models
{
    public class MockPieRepository : IPieRespository
    {
        private List<Pie> _pies;

        public MockPieRepository()
        {
            if (_pies == null)
            {
                InitializePies();
            }
        }

        private void InitializePies()
        {
            _pies = new List<Pie>
                {
                    new Pie {Id = 1, Name = "Apple Pie", Price = 12.95M,
                            ShortDescription = "Our famous apple pies",
                            LongDescription = "This is apple long description",
                            IsPieOfTheWeek = false,
                            ImageUrl = "https://picsum.photos/200/300"},
                    new Pie {Id = 2, Name = "Orange Pie", Price = 12.95M,
                            ShortDescription = "Our famous Orange pies",
                            LongDescription = "This is Orange long description",
                            IsPieOfTheWeek = false,
                            ImageUrl = "https://picsum.photos/200/300/?blur",},
                    new Pie {Id = 3, Name = "Cherry Pie", Price = 12.95M,
                            ShortDescription = "Our famous apple pies",
                            LongDescription = "This is Cherry long description",
                            ImageUrl = "https://picsum.photos/200/300?grayscale",
                            IsPieOfTheWeek = true},
                    new Pie {Id = 4, Name = "Cheese Pie", Price = 12.95M,
                            ShortDescription = "Our famous Cheese pies",
                            LongDescription = "This is Cheese long description",
                            ImageUrl = "https://picsum.photos/200/300?grayscale",
                            IsPieOfTheWeek = false}

                };
        }
        public IEnumerable<Pie> GetAllPie()
        {
            return _pies;
        }

        public Pie GetPieById(int pieId)
        {
            return _pies.FirstOrDefault(p => p.Id == pieId);
        }
    }
}
