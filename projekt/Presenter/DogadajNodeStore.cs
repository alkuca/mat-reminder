using System;
namespace projekt
{
	public class DogadajNodeStore : Gtk.NodeStore
	{
		public DogadajNodeStore() : base(typeof(DogadajNode))
		{
		}

		public void dodajDogadaj(Dogadaj d, string color)
		{
			DogadajNode temp = new DogadajNode(d, color);
			this.AddNode(temp);
		}
	}
}
