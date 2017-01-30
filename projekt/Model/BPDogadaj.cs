using System;
using System.Collections.Generic;
using Mono.Data.Sqlite;
namespace projekt
{
	public static class BPDogadaj
	{
		public static void SpremiDogadaj(Dogadaj d)
		{
			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = String.Format(@"Insert into dogadaj (datum, opis, vrijeme, mjesto, prioritet)
			Values ('{0}', '{1}', '{2}', '{3}', '{4}')", d.Datum.ToFileTime(), d.Opis, d.Vrijeme, d.Mjesto, d.Prioritet);

			command.ExecuteNonQuery();

			command.Dispose();

			BP.zatvoriKonekciju();
		}

		public static void IzmjeniDogadaj(Dogadaj d)
		{
			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = String.Format(@"Update dogadaj
			set datum = '{0}', opis = '{1}', vrijeme = '{2}', mjesto = '{3}', prioritet = '{4}'
			where id = '{5}'", d.Datum.ToFileTime(), d.Opis, d.Vrijeme, d.Mjesto, d.Prioritet, d.Id);

			command.ExecuteNonQuery();

			command.Dispose();

			BP.zatvoriKonekciju();
		}

		public static void IzbrisiDatum(long id)
		{
			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = String.Format(@"Delete from dogadaj Where id = '{0}'", id);

			command.ExecuteNonQuery();

			command.Dispose();

			BP.zatvoriKonekciju();
		}

		public static List<Dogadaj> DohavtiSve()
		{
			BP.otvoriKonekciju();

			List<Dogadaj> listaDogadaja = new List<Dogadaj>();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = "Select * from dogadaj order by datum";

			SqliteDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				Dogadaj temp = new Dogadaj();

				temp.Id = (int)(Int64)reader["id"];
				temp.Datum = DateTime.FromFileTime(reader.GetInt64(1));
				temp.Opis = (string)reader["opis"];
				temp.Vrijeme = (string)reader["vrijeme"];
				temp.Mjesto = (string)reader["mjesto"];
				temp.Prioritet = (string)reader["prioritet"];

				listaDogadaja.Add(temp);
			}

			reader.Dispose();
			command.Dispose();

			BP.zatvoriKonekciju();

			return listaDogadaja;
		}

		public static List<Dogadaj> DohavtiSvePrioritet()
		{
			BP.otvoriKonekciju();

			List<Dogadaj> listaDogadaja = new List<Dogadaj>();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = "Select * from dogadaj order by prioritet desc";

			SqliteDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				Dogadaj temp = new Dogadaj();

				temp.Id = (int)(Int64)reader["id"];
				temp.Datum = DateTime.FromFileTime(reader.GetInt64(1));
				temp.Opis = (string)reader["opis"];
				temp.Vrijeme = (string)reader["vrijeme"];
				temp.Mjesto = (string)reader["mjesto"];
				temp.Prioritet = (string)reader["prioritet"];

				listaDogadaja.Add(temp);
			}

			reader.Dispose();
			command.Dispose();

			BP.zatvoriKonekciju();

			return listaDogadaja;
		}
	}
}
