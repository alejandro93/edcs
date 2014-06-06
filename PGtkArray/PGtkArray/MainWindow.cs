using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
//		Build ();
//		
//		Gdk.Color greenColor = new Gdk.Color(0,255,0);
//		
//		int count = arrayButton.Rows * arrayButton.Columns;
//		
//		for (int index = 0; index < count; index++){
//			arrayButton.Get (index).Label = string.Format ("{0}", index+1);
//			if((index+1)%2 == 0)
//				arrayButton[index].ModifyBg(StateType.Normal, greenColor);
//		}
//		
//		arrayButton.Get(2,4).Label = "*";
//		arrayButton[3,5].Label = "*";
//		string[] Labels = {"Uno", "Dos", "Tres", "Cuatro"};
//		arrayButton.SetLabels(Labels);
//		
//		Table table = (Table)arrayButton.Child;
//		Console.WriteLine("diseñador: table.Children.Length={0}", table.Children.Length);
//		
//		
//		arrayButton.Rows = 9;
//		arrayButton.Columns = 10;
//		Console.WriteLine("Rows=9, Columns=10: table.Children.Length={0}", table.Children.Length);
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}
