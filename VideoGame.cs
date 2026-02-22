using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace business_l
{
	public class VideoGame
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(150)]
		public string Title { get; set; }

		[Range(0, 1000)] 
		public decimal Price { get; set; }

		
		[Required]
		public int StudioId { get; set; }

		[ForeignKey(nameof(StudioId))]
		public Studio Studio { get; set; }

		
		[Required]
		public int PlatformId { get; set; }

		[ForeignKey(nameof(PlatformId))]
		public Platform Platform { get; set; }


		
		private VideoGame() { }

		
		public VideoGame(string title, decimal price, int studioId, int platformId)
		{
			this.Title = title;
			this.Price = price;
			this.StudioId = studioId;
			this.PlatformId = platformId;
		}
	}
}
