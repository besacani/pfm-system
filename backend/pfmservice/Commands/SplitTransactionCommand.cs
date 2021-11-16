using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pfmservice.Models;

namespace pfmservice.Commands
{
    public class SplitTransactionCommand
    {
        public Split Splits { get; set; }
    }
}