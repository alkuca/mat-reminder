
// This file has been generated by the GUI designer. Do not modify.
namespace projekt
{
	public partial class UnosDogadaja
	{
		private global::Gtk.HBox hbox2;

		private global::Gtk.VBox vbox5;

		private global::Gtk.Calendar calendar4;

		private global::Gtk.Fixed fixed1;

		private global::Gtk.VBox vbox4;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Label label1;

		private global::Gtk.Entry entryOpis;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Label label2;

		private global::Gtk.Entry entryVrijeme;

		private global::Gtk.HBox hbox5;

		private global::Gtk.Label label3;

		private global::Gtk.Entry entryMjesto;

		private global::Gtk.HBox hbox6;

		private global::Gtk.Label label4;

		private global::Gtk.ComboBox combobox1;

		private global::Gtk.HButtonBox hbuttonbox1;

		private global::Gtk.Button buttonSpremi;

		private global::Gtk.Button buttonOdustani;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget projekt.UnosDogadaja
			this.Name = "projekt.UnosDogadaja";
			this.Title = global::Mono.Unix.Catalog.GetString("Unos Dogadaja");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			this.BorderWidth = ((uint)(15));
			// Container child projekt.UnosDogadaja.Gtk.Container+ContainerChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.vbox5 = new global::Gtk.VBox();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.calendar4 = new global::Gtk.Calendar();
			this.calendar4.CanFocus = true;
			this.calendar4.Name = "calendar4";
			this.calendar4.DisplayOptions = ((global::Gtk.CalendarDisplayOptions)(35));
			this.vbox5.Add(this.calendar4);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.calendar4]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.fixed1 = new global::Gtk.Fixed();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			this.vbox5.Add(this.fixed1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.fixed1]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			this.hbox2.Add(this.vbox5);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.vbox5]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.vbox4 = new global::Gtk.VBox();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Opis:");
			this.hbox3.Add(this.label1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.label1]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.entryOpis = new global::Gtk.Entry();
			this.entryOpis.CanFocus = true;
			this.entryOpis.Name = "entryOpis";
			this.entryOpis.IsEditable = true;
			this.entryOpis.InvisibleChar = '●';
			this.hbox3.Add(this.entryOpis);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.entryOpis]));
			w5.Position = 1;
			this.vbox4.Add(this.hbox3);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hbox3]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Vrijeme (MM:SS):");
			this.hbox4.Add(this.label2);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.label2]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.entryVrijeme = new global::Gtk.Entry();
			this.entryVrijeme.CanFocus = true;
			this.entryVrijeme.Name = "entryVrijeme";
			this.entryVrijeme.IsEditable = true;
			this.entryVrijeme.InvisibleChar = '●';
			this.hbox4.Add(this.entryVrijeme);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.entryVrijeme]));
			w8.Position = 1;
			this.vbox4.Add(this.hbox4);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hbox4]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Mjesto:");
			this.hbox5.Add(this.label3);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.label3]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.entryMjesto = new global::Gtk.Entry();
			this.entryMjesto.CanFocus = true;
			this.entryMjesto.Name = "entryMjesto";
			this.entryMjesto.IsEditable = true;
			this.entryMjesto.InvisibleChar = '●';
			this.hbox5.Add(this.entryMjesto);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.entryMjesto]));
			w11.Position = 1;
			this.vbox4.Add(this.hbox5);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hbox5]));
			w12.Position = 2;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Prioritet:");
			this.hbox6.Add(this.label4);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.label4]));
			w13.Position = 0;
			w13.Expand = false;
			w13.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.combobox1 = global::Gtk.ComboBox.NewText();
			this.combobox1.AppendText(global::Mono.Unix.Catalog.GetString("Visok"));
			this.combobox1.AppendText(global::Mono.Unix.Catalog.GetString("Obican"));
			this.combobox1.AppendText(global::Mono.Unix.Catalog.GetString("Nizak"));
			this.combobox1.Name = "combobox1";
			this.hbox6.Add(this.combobox1);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.combobox1]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			this.vbox4.Add(this.hbox6);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hbox6]));
			w15.Position = 3;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbuttonbox1 = new global::Gtk.HButtonBox();
			this.hbuttonbox1.Name = "hbuttonbox1";
			this.hbuttonbox1.Spacing = 20;
			this.hbuttonbox1.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(3));
			// Container child hbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
			this.buttonSpremi = new global::Gtk.Button();
			this.buttonSpremi.CanFocus = true;
			this.buttonSpremi.Name = "buttonSpremi";
			this.buttonSpremi.UseUnderline = true;
			this.buttonSpremi.Label = global::Mono.Unix.Catalog.GetString("Spremi");
			this.hbuttonbox1.Add(this.buttonSpremi);
			global::Gtk.ButtonBox.ButtonBoxChild w16 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox1[this.buttonSpremi]));
			w16.Expand = false;
			w16.Fill = false;
			// Container child hbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOdustani = new global::Gtk.Button();
			this.buttonOdustani.CanFocus = true;
			this.buttonOdustani.Name = "buttonOdustani";
			this.buttonOdustani.UseUnderline = true;
			this.buttonOdustani.Label = global::Mono.Unix.Catalog.GetString("Odustani");
			this.hbuttonbox1.Add(this.buttonOdustani);
			global::Gtk.ButtonBox.ButtonBoxChild w17 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox1[this.buttonOdustani]));
			w17.Position = 1;
			w17.Expand = false;
			w17.Fill = false;
			this.vbox4.Add(this.hbuttonbox1);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hbuttonbox1]));
			w18.PackType = ((global::Gtk.PackType)(1));
			w18.Position = 4;
			w18.Expand = false;
			w18.Fill = false;
			this.hbox2.Add(this.vbox4);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.vbox4]));
			w19.Position = 1;
			w19.Expand = false;
			w19.Fill = false;
			this.Add(this.hbox2);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 480;
			this.DefaultHeight = 300;
			this.Show();
		}
	}
}
