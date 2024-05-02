using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.Model
{
    public class MenuItem
    {
		private string? _name;
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private decimal _price;
		public decimal Price
		{
			get { return _price; }
			set { _price = value; }
		}

		private string? _description;
		public string Description
		{
			get { return _description; }
			set { _description = value; }
		}

		private string _image;
		public string Image
		{
			get { return _image; }
			set { _image = value; }
		}

	}
}
