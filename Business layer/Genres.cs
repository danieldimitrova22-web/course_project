using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_layer
{
	public class Genres
	{
		[Key]
		public int Genre_id { get; set; }

		[Required]
		[MaxLength(30, ErrorMessage = "The genre name must be up to 30 characters!")]
		public string Name { get; set; }

		[Required]
		[MaxLength(2000, ErrorMessage = "The genre name must be up to 2000 characters!")]
		public string Description { get; set; }

		[Required]
		public List<Games> Games { get; set; }

		private Genres()
		{
		}
	    
	    public Genres(int genre_id, string name, string description, List<Games> games)
		{
			Genre_id = genre_id;
			Name = name;
			Description = description;
			Games = games;
		}
	}
}