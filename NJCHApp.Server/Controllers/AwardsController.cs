using Microsoft.AspNetCore.Mvc;
using NJCHApp.Server.Models;

namespace NJCHApp.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AwardsController : ControllerBase
    {

        private readonly ILogger<AwardsController> _logger;

        public AwardsController(ILogger<AwardsController> logger)
        {
            _logger = logger;
        }

        private static readonly IEnumerable<Awards> Items = new[]
        {
            new Awards{Id = 1, Title = "Award-1", ImageId=1, Ranking=2021, ItemType=1 },
            new Awards{Id = 2, Title = "Award-2", ImageId=2, Ranking=2011, ItemType=1 },
            new Awards{Id = 3, Title = "Award-3", ImageId=3, Ranking=2024, ItemType=1 },
            new Awards{Id = 4, Title = "Award-4", ImageId=4, Ranking=2010, ItemType=1 },
            new Awards{Id = 5, Title = "Award-5", ImageId=5, Ranking=2014, ItemType=1 },
            new Awards{Id = 6, Title = "Award-6", ImageId=6, Ranking=2009, ItemType=1 },
            new Awards{Id = 7, Title = "Award-7", ImageId=7, Ranking=2015, ItemType=1 },
            new Awards{Id = 8, Title = "Award-8", ImageId=8, Ranking=2017, ItemType=1 },
            new Awards{Id = 9, Title = "Award-9", ImageId=9, Ranking=2019, ItemType=1 },
            new Awards{Id = 10, Title = "Award-10", ImageId=10, Ranking=2022, ItemType=1 },
            new Awards{Id = 11, Title = "Accreditation-1", ImageId=11, Ranking=2020, ItemType=2 },
            new Awards{Id = 12, Title = "Accreditation-2", ImageId=12, Ranking=2021, ItemType=2 },
            new Awards{Id = 13, Title = "Accreditation-3", ImageId=13, Ranking=2024, ItemType=2 },
            new Awards{Id = 14, Title = "Accreditation-4", ImageId=14, Ranking=2009, ItemType=2 },
            new Awards{Id = 15, Title = "Accreditation-5", ImageId=15, Ranking=2012, ItemType=2 },
            new Awards{Id = 16, Title = "Accreditation-6", ImageId=16, Ranking=2222, ItemType=2 },
            new Awards{Id = 17, Title = "Accreditation-7", ImageId=17, Ranking=2019, ItemType=2 },
            new Awards{Id = 18, Title = "Accreditation-8", ImageId=18, Ranking=2010, ItemType=2 },
            new Awards{Id = 19, Title = "Accreditation-9", ImageId=19, Ranking=2023, ItemType=2 },
            new Awards{Id = 20, Title = "Accreditation-10", ImageId=20, Ranking=2022, ItemType=2 }
        };

        [HttpGet(Name = "GetAwards")]
        public Awards[] Get()
        {
            Awards[] items = Items.Where(i => i.ItemType == 1).ToArray();
            return items;
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            string theName = "Paul";

            switch (id)
            {
                case 1:
                    theName = "Charles";
                    goto default;
                case 2:
                    theName = "NJCH";
                    goto default;
                default:
                    return $"Hello {theName}!";
            }
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
