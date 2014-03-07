using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		
		Suma.Clicked += delegate{
		decimal d= decimal.Parse (entry1.Text) + decimal.Parse (entry2.Text);
		solucion.Text= d.ToString();
		};
		

		
		Resta.Clicked += delegate{
		decimal d= decimal.Parse (entry1.Text) - decimal.Parse (entry2.Text);
		solucion.Text= d.ToString();
		};
		

		
		Multiplicacion.Clicked += delegate{
		decimal d= decimal.Parse (entry1.Text) * decimal.Parse (entry2.Text);
		solucion.Text= d.ToString();
		};
		

		
		Division.Clicked += delegate{
		decimal d= decimal.Parse (entry1.Text) / decimal.Parse (entry2.Text);
		solucion.Text= d.ToString();
		};
		
		C.Clicked += delegate {
			entry1.Text = string.Empty;
			entry2.Text = string.Empty;
			solucion.Text = string.Empty;
			
		};
		
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}
