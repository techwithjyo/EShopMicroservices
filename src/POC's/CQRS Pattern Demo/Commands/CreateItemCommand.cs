using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Pattern_Demo.Commands
{
    internal class CreateItemCommand
    {
        public string Name { get; set; }
    }
}
