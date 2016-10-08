using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LELToolCore.Models
{
	public class Expression
	{
		public long Id { get; set; }
		public string Content { get; set; }
		public ICollection<Symbol> Symbols { get; set; }
		public SymbolAttribute Attribute { get; set; }
				
		public SocialNWManager SocialNWManager { get; set; }

		public Expression()
		{
			Symbols = new HashSet<Symbol>();			
		}		
	}
}
