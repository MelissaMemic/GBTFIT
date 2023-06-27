using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GBT.Models
{
	public class BaseEntity
	{
		[Key]
		public int ID { get; set; }
		public DateTime DateCreated { get; set; }
		public DateTime DateModified { get; set; }
    }
}

