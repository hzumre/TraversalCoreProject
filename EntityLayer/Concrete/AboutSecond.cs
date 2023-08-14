using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class AboutSecond
	{
		[Key]
		public int AboutSecondID { get; set; }
        public string Title { get; set; }
        public string TitleSecond { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
