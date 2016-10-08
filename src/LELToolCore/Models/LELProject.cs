using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LELToolCore.Models
{
    public class LELProject
    {
		public long Id { get; set; }
		public string Name { get; set; }
		public ICollection<User> Users { get; set; }
		public ICollection<Symbol> Symbols { get; set; }
     }
}
