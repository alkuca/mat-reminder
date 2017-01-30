using System;
using System.Collections.Generic;
using Gtk;
using projekt;

public partial class MainWindow : Gtk.Window
{
	public DogadajNodeStore dogadajPresenter;
	public List<Dogadaj> listaDogadaja;

	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		Build();

		buttonUnesi.Clicked += unosDogadaja;
		buttonIzbrisi.Clicked += brisanjeDogadaja;
		buttonIzmjeni.Clicked += izmjenaDogadaja;
		buttonBitniDogadaji.Clicked += bitniDogadaji;

		calendar2.MonthChanged += izmjenaMjeseca;

		dogadajPresenter = new DogadajNodeStore();

		nodeview1.NodeStore = dogadajPresenter;

		nodeview1.AppendColumn("Datum", new CellRendererText(), "text", 0);
		nodeview1.AppendColumn("Opis", new CellRendererText(), "text", 1);
		nodeview1.AppendColumn("Vrijeme", new CellRendererText(), "text", 2, "foreground", 5);
		nodeview1.AppendColumn("Mjesto", new CellRendererText(), "text", 3);
		nodeview1.AppendColumn("Prioritet", new CellRendererText(), "text", 4);

		listaDogadaja = BPDogadaj.DohavtiSve();

		foreach (Dogadaj i in listaDogadaja)
		{
			string boja = provjeraDatum(i);
			dogadajPresenter.dodajDogadaj(i, boja);
		}

		oznacivanjeDana();
	}

	protected void unosDogadaja(object sender, EventArgs a)
	{
		Dogadaj dogadaj = new Dogadaj();

		var temp = new UnosDogadaja(dogadaj);

		temp.Destroyed += onDestroy;
	}

	protected void izmjenaDogadaja(object sender, EventArgs a)
	{
		DogadajNode dogadajSelected = nodeview1.NodeSelection.SelectedNode as DogadajNode;
		if (dogadajSelected == null)
			return;
		
		Dogadaj dogadaj = new Dogadaj();

		foreach (var i in listaDogadaja)
		{
			if (i.Id == dogadajSelected.id)
			{
				dogadaj = i;
				break;
			}
		}

		var temp = new UnosDogadaja(dogadaj);

		temp.Destroyed += onDestroy;
	}

	protected void brisanjeDogadaja(object sender, EventArgs a)
	{
		DogadajNode dogadajSelected = nodeview1.NodeSelection.SelectedNode as DogadajNode;
		if (dogadajSelected == null)//Ako ni jedan dogadaj nije selectiran funkcija se prekida
			return;

		foreach (var i in listaDogadaja)
		{
			if (i.Id == dogadajSelected.id)
			{
				BPDogadaj.IzbrisiDatum(i.Id);
				break;
			}
		}

		osvjezi();
		oznacivanjeDana();
	}

	protected void bitniDogadaji(object sender, EventArgs a)
	{
		var temp = new BitniDogadaji();
	}

	protected void izmjenaMjeseca(object sender, EventArgs a)
	{
		oznacivanjeDana();
	}

	protected void osvjezi()
	{
		dogadajPresenter.Clear();

		listaDogadaja = BPDogadaj.DohavtiSve();

		foreach (Dogadaj i in listaDogadaja)
		{
			string boja = provjeraDatum(i);
			dogadajPresenter.dodajDogadaj(i, boja);
		}
	}

	protected void oznacivanjeDana()
	{
		calendar2.ClearMarks();

		foreach (Dogadaj i in listaDogadaja)
		{
			Console.WriteLine(i.Datum.Month);
			Console.WriteLine(calendar2.Month);
			//Ako je pronaden takav datum onda se oznacava njegov dan
			if (i.Datum.Month == calendar2.Month + 1 && i.Datum.Year == calendar2.Year)
			{
				calendar2.MarkDay((uint)i.Datum.Day);
			}
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

	protected void onDestroy(object sender, EventArgs a)
	{
		osvjezi();
	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a)
	{
		Application.Quit();
		a.RetVal = true;
	}
}
