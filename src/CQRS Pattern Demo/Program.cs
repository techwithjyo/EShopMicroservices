using CQRS_Pattern_Demo.Commands;
using CQRS_Pattern_Demo.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Pattern_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new item
            var createItemCommand = new CreateItemCommand { Name = "Item 1" };
            var createItemCommandHandler = new CreateItemCommandHandler();
            var itemId = createItemCommandHandler.Handle(createItemCommand);
            Console.WriteLine($"Item created with Id: {itemId}");


            // Get the created item
            var getItemQuery = new GetItemQuery { Id = itemId };
            var getItemQueryHandler = new GetItemQueryHandler();
            var item = getItemQueryHandler.Handle(getItemQuery);
            Console.WriteLine($"Item retrieved with Id: {item.Id} and Name: {item.Name}");
        }
    }
}
