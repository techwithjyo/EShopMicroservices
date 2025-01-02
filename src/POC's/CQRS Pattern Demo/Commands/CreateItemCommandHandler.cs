using CQRS_Pattern_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Pattern_Demo.Commands
{
    internal class CreateItemCommandHandler
    {
        private static List<Item> _items = new List<Item>();
        private static int _idCounter = 1;

        public int Handle(CreateItemCommand command)
        {
            var item = new Item { Id = _idCounter++, Name = command.Name };
            _items.Add(item);
            return item.Id;
        }
    }
}
