
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;
	private global::Gtk.Entry entry1;
	private global::Gtk.Entry entry2;
	private global::Gtk.Entry solucion;
	private global::Gtk.HBox hbox3;
	private global::Gtk.Button C;
	private global::Gtk.HBox hbox2;
	private global::Gtk.Button Resta;
	private global::Gtk.Button Division;
	private global::Gtk.Button Potencia;
	private global::Gtk.HBox hbox1;
	private global::Gtk.Button Suma;
	private global::Gtk.Button Multiplicacion;
	private global::Gtk.Button Raiz;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.entry1 = new global::Gtk.Entry ();
		this.entry1.CanFocus = true;
		this.entry1.Name = "entry1";
		this.entry1.IsEditable = true;
		this.entry1.InvisibleChar = '•';
		this.vbox1.Add (this.entry1);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.entry1]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.entry2 = new global::Gtk.Entry ();
		this.entry2.CanFocus = true;
		this.entry2.Name = "entry2";
		this.entry2.IsEditable = true;
		this.entry2.InvisibleChar = '•';
		this.vbox1.Add (this.entry2);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.entry2]));
		w2.Position = 1;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.solucion = new global::Gtk.Entry ();
		this.solucion.CanFocus = true;
		this.solucion.Name = "solucion";
		this.solucion.IsEditable = true;
		this.solucion.InvisibleChar = '•';
		this.vbox1.Add (this.solucion);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.solucion]));
		w3.Position = 2;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox ();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.C = new global::Gtk.Button ();
		this.C.CanFocus = true;
		this.C.Name = "C";
		this.C.UseUnderline = true;
		this.C.Label = global::Mono.Unix.Catalog.GetString ("C");
		this.hbox3.Add (this.C);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.C]));
		w4.Position = 2;
		w4.Expand = false;
		w4.Fill = false;
		this.vbox1.Add (this.hbox3);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox3]));
		w5.PackType = ((global::Gtk.PackType)(1));
		w5.Position = 3;
		w5.Expand = false;
		w5.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox ();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.Resta = new global::Gtk.Button ();
		this.Resta.CanFocus = true;
		this.Resta.Name = "Resta";
		this.Resta.UseUnderline = true;
		this.Resta.Label = global::Mono.Unix.Catalog.GetString ("Resta");
		this.hbox2.Add (this.Resta);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.Resta]));
		w6.Position = 0;
		w6.Expand = false;
		w6.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.Division = new global::Gtk.Button ();
		this.Division.CanFocus = true;
		this.Division.Name = "Division";
		this.Division.UseUnderline = true;
		this.Division.Label = global::Mono.Unix.Catalog.GetString ("División");
		this.hbox2.Add (this.Division);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.Division]));
		w7.Position = 1;
		w7.Expand = false;
		w7.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.Potencia = new global::Gtk.Button ();
		this.Potencia.CanFocus = true;
		this.Potencia.Name = "Potencia";
		this.Potencia.UseUnderline = true;
		this.Potencia.Label = global::Mono.Unix.Catalog.GetString ("Potencia");
		this.hbox2.Add (this.Potencia);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.Potencia]));
		w8.Position = 2;
		w8.Expand = false;
		w8.Fill = false;
		this.vbox1.Add (this.hbox2);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox2]));
		w9.PackType = ((global::Gtk.PackType)(1));
		w9.Position = 4;
		w9.Expand = false;
		w9.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.Suma = new global::Gtk.Button ();
		this.Suma.CanFocus = true;
		this.Suma.Name = "Suma";
		this.Suma.UseUnderline = true;
		this.Suma.Label = global::Mono.Unix.Catalog.GetString ("Suma");
		this.hbox1.Add (this.Suma);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.Suma]));
		w10.Position = 0;
		w10.Expand = false;
		w10.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.Multiplicacion = new global::Gtk.Button ();
		this.Multiplicacion.CanFocus = true;
		this.Multiplicacion.Name = "Multiplicacion";
		this.Multiplicacion.UseUnderline = true;
		this.Multiplicacion.Label = global::Mono.Unix.Catalog.GetString ("Multiplicación");
		this.hbox1.Add (this.Multiplicacion);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.Multiplicacion]));
		w11.Position = 1;
		w11.Expand = false;
		w11.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.Raiz = new global::Gtk.Button ();
		this.Raiz.CanFocus = true;
		this.Raiz.Name = "Raiz";
		this.Raiz.UseUnderline = true;
		this.Raiz.Label = global::Mono.Unix.Catalog.GetString ("Raíz");
		this.hbox1.Add (this.Raiz);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.Raiz]));
		w12.Position = 2;
		w12.Expand = false;
		w12.Fill = false;
		this.vbox1.Add (this.hbox1);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
		w13.PackType = ((global::Gtk.PackType)(1));
		w13.Position = 5;
		w13.Expand = false;
		w13.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 210;
		this.DefaultHeight = 300;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
	}
}
