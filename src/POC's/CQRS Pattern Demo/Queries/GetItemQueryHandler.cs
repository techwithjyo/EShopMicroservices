using CQRS_Pattern_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Pattern_Demo.Queries
{
    internal class GetItemQueryHandler
    {
        private static List<Item> _items = new List<Item>
    {
        new Item { Id = 1, Name = "Item1" },
        new Item { Id = 2, Name = "Item2" }
    };

        public Item Handle(GetItemQuery query)
        {
            return _items.FirstOrDefault(i => i.Id == query.Id);
        }
    }
}
