using System;
using System.Collections.Generic;
using Gtk;

namespace projekt
{
	public partial class BitniDogadaji : Gtk.Window
	{
		public List<Dogadaj> listaDogadaja;

		public BitniDogadaji() :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();

			DogadajNodeStore dogadajPresenter = new DogadajNodeStore();

			nodeview1.NodeStore = dogadajPresenter;

			nodeview1.AppendColumn("Datum", new CellRendererText(), "text", 0);
			nodeview1.AppendColumn("Opis", new CellRendererText(), "text", 1);
			nodeview1.AppendColumn("Vrijeme", new CellRendererText(), "text", 2, "foreground", 5);
			nodeview1.AppendColumn("Mjesto", new CellRendererText(), "text", 3);
			nodeview1.AppendColumn("Prioritet", new CellRendererText(), "text", 4);

			listaDogadaja = BPDogadaj.DohavtiSvePrioritet();

			foreach (var i in listaDogadaja)
			{
				string boja = provjeraDatum(i);

				dogadajPresenter.dodajDogadaj(i, boja);
			}
		}

		protected string provjeraDatum(Dogadaj d)
		{
			int satiD = int.Parse(d.Vrijeme.Substring(0, 2));
			int minuteD = int.Parse(d.Vrijeme.Substring(3, 2));

			foreach (var i in listaDogadaja)
			{
				if (d.Id == i.Id)
					continue;

				int sati = int.Parse(i.Vrijeme.Substring(0, 2));
				int minute = int.Parse(i.Vrijeme.Substring(3, 2));

				DateTime jedan = new DateTime(i.Datum.Year, i.Datum.Month, i.Datum.Day, sati, minute, 0);
				DateTime dva = new DateTime(d.Datum.Year, d.Datum.Month, d.Datum.Day, satiD, minuteD, 0);

				if (Math.Abs((jedan - dva).TotalHours) <= 1)
				{
					return "red";
				}
			}
			return null;
		}
	}
}
