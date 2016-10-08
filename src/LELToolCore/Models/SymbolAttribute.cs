using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LELToolCore.Models
{
    public class SymbolAttribute
    {		
		public int Id { get; set; }
		public ICollection<Expression> Expressions { get; set; }

		public SymbolAttribute()
		{
			Expressions = new HashSet<Expression>();
		}
	}
}
