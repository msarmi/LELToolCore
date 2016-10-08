using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LELToolCore.Models
{
    public class Comment
    {
		public long Id { get; set; }
		public string Content { get; set; }
		public User Author { get; set; }
		public ICollection<Comment> Replies { get; set; }

		public Comment() {
			Replies = new HashSet<Comment>();
		}
	}
}
