using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LELToolCore.Models
{
    public class SocialNWManager
    {		
		public long Id { get; set; }
		public List<User> Likes { get; set; }
		public List<User> Dislikes { get; set; }
		public List<Comment> Comments { get; set; }

		public SocialNWManager() {
			Likes = new List<User>();
			Dislikes = new List<User>();
			Comments = new List<Comment>();
		}
	}
}
