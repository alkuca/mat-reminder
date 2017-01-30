using System;
namespace projekt
{
	public class DogadajNode : Gtk.TreeNode
	{
		public long id;

		[Gtk.TreeNodeValue(Column = 0)]
		public String datum;

		[Gtk.TreeNodeValue(Column = 1)]
		public String opis;

		[Gtk.TreeNodeValue(Column = 2)]
		public String vrijeme;

		[Gtk.TreeNodeValue(Column = 3)]
		public String mjesto;

		[Gtk.TreeNodeValue(Column = 4)]
		public String prioritet;

		[Gtk.TreeNodeValue(Column = 5)]
		public String color;

		public DogadajNode(Dogadaj d, string color)
		{
			this.id = d.Id;

			this.datum = d.Datum.ToString().Substring(0, d.Datum.ToString().Length - 8);
			this.opis = d.Opis;
			this.vrijeme = d.Vrijeme;
			this.mjesto = d.Mjesto;
			this.prioritet = d.Prioritet;
			this.color = color;
		}
	}
}
