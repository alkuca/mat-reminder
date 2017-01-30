using System;
namespace projekt
{
	public class Dogadaj
	{
		private long id;
		private DateTime datum;
		private string opis;
		private string vrijeme;
		private string mjesto;
		private string prioritet;

		public Dogadaj()
		{
			id = -1;
		}

		public DateTime Datum
		{
			get
			{
				return datum;
			}

			set
			{
				datum = value;
			}
		}

		public string Opis
		{
			get
			{
				return opis;
			}

			set
			{
				opis = value;
			}
		}

		public string Vrijeme
		{
			get
			{
				return vrijeme;
			}

			set
			{
				vrijeme = value;
			}
		}

		public string Mjesto
		{
			get
			{
				return mjesto;
			}

			set
			{
				mjesto = value;
			}
		}

		public string Prioritet
		{
			get
			{
				return prioritet;
			}

			set
			{
				prioritet = value;
			}
		}

		public long Id
		{
			get
			{
				return Id1;
			}

			set
			{
				Id1 = value;
			}
		}

		public long Id1
		{
			get
			{
				return id;
			}

			set
			{
				id = value;
			}
		}
	}
}
