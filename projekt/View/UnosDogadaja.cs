using System;
using Gtk;

namespace projekt
{
	public partial class UnosDogadaja : Gtk.Window
	{
		public Dogadaj temp;

		public UnosDogadaja(Dogadaj dogadaj) :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();

			temp = dogadaj;

			buttonSpremi.Clicked += spremi;
			buttonOdustani.Clicked += odustani;


			if (temp.Id != -1)
			{
				this.Title = "Izmjena dogadaja";
				calendar4.Date = temp.Datum;
				entryOpis.Text = temp.Opis;
				entryMjesto.Text = temp.Mjesto;
				entryVrijeme.Text = temp.Vrijeme;

				switch (temp.Prioritet)
				{
					case "Nizak":
						combobox1.Active = 2;
						break;
					case "Obican":
						combobox1.Active = 1;
						break;
					case "Visok":
						combobox1.Active = 0;
						break;
				}
			}
		}

		protected void spremi(object sender, EventArgs a)
		{
			if (entryOpis.Text == "" || entryVrijeme.Text == "" || entryMjesto.Text == "" || combobox1.ActiveText == null)
			{
				Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "Sva polja moraju biti unesena!");

				d.Run();
				d.Destroy();
				return;
			}
			temp.Datum = calendar4.Date;
			temp.Opis = entryOpis.Text;
			temp.Vrijeme = entryVrijeme.Text;
			temp.Mjesto = entryMjesto.Text;
			temp.Prioritet = combobox1.ActiveText;

			if (temp.Id != -1)
			{
				BPDogadaj.IzmjeniDogadaj(temp);
				this.Destroy();
				return;
			}
			BPDogadaj.SpremiDogadaj(temp);

			this.Destroy();
		}

		protected void odustani(object sender, EventArgs a)
		{
			this.Destroy();
		}
	}
}
