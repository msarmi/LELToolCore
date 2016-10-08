using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LELToolCore.Models
{
    public class Symbol
    {
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public User Author { get; set; }
		public virtual ICollection<Synonym> Synonyms { get; set; }

		public SymbolAttribute Notion { get; set; } 
		public SymbolAttribute BehaviouralResponse { get; set; }
		public Category Category { get; set; }
		
		public SocialNWManager SocialNWManager { get; set; }

		public Symbol() {
			Synonyms = new HashSet<Synonym>();
		}

		public Symbol merge(Symbol anotherSymbol)
		{
			return null;
		}
	}
}
