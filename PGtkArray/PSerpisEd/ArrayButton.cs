using System;
using Gtk;
using System.Collections.Generic;
namespace Serpis.Ed

{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class ArrayButton : Gtk.Bin
	{
		
		private int rows = 1;
		private int columns = 1;
		
		private Table table;
		
		private List<Button> buttons;
	
		public ArrayButton ()
		{
			this.Build ();
			
			/*table = new Table(1,1, true);
			Add (table);*/
			
			refresh ();
		}
		
		private void refresh(){
			/*Widget[] widgets = table.Children;
			foreach(Widget widget in widgets)
				table.Remove (widget);
				*/
			if(table != null)
				Remove (table);
			
			table = new Table((uint)rows, (uint)columns, true);
			table.Visible = true;
			Add (table);
			
			buttons = new List<Button>();
			

			for (uint row = 0; row < rows; row++){
				for (uint column = 0; column < columns; column++){
					Button button = new Button();
					button.Visible = true;
					button.Label = string.Format("[{0},{1}]",row,column);
					table.Attach(button, column, column + 1, row, row + 1);
				}
					
			}
		}
		
		public int Rows {
			get{ return rows; }
			set{ 
				rows = value;
				refresh ();
			}
		}
		public int Columns {
			get{ return columns;}
			set{ 
				columns = value;
				refresh ();
			}
		}
		
		public Button Get(int index){
			return buttons[index];
		}
		public Button this[int index]{
			get{return buttons[index];}
		}
		public Button Get(int row, int column){
			return buttons[row * column + column];
		}
		public Button this[int row, int column]{
			get { return buttons[row * columns + column];}
		}
		public void SetLabels(string[] labels){
			for (int index = 0; index < buttons.Count; index++)
				if (index < labels.Length)
					buttons[index].Label = labels[index];
			else
				buttons[index].Visible = index < labels.Length;
		}
	}
}