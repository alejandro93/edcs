
// This file has been generated by the GUI designer. Do not modify.
namespace PGtkArray
{
	public partial class MyWidget
	{
		private global::Gtk.Table table1;
		private global::Gtk.Entry entry3;
		private global::Gtk.Entry entry4;
		private global::Gtk.Label label4;
		private global::Gtk.Label label5;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget PGtkArray.MyWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "PGtkArray.MyWidget";
			// Container child PGtkArray.MyWidget.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table (((uint)(2)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.entry3 = new global::Gtk.Entry ();
			this.entry3.CanFocus = true;
			this.entry3.Name = "entry3";
			this.entry3.IsEditable = true;
			this.entry3.InvisibleChar = '•';
			this.table1.Add (this.entry3);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1 [this.entry3]));
			w1.LeftAttach = ((uint)(1));
			w1.RightAttach = ((uint)(2));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entry4 = new global::Gtk.Entry ();
			this.entry4.CanFocus = true;
			this.entry4.Name = "entry4";
			this.entry4.IsEditable = true;
			this.entry4.InvisibleChar = '•';
			this.table1.Add (this.entry4);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1 [this.entry4]));
			w2.TopAttach = ((uint)(1));
			w2.BottomAttach = ((uint)(2));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Dirección");
			this.table1.Add (this.label4);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.label4]));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Población");
			this.table1.Add (this.label5);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1 [this.label5]));
			w4.TopAttach = ((uint)(1));
			w4.BottomAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add (this.table1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}