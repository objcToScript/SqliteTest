using System;
using System.Reflection;
using Gdk;
public static class objectExtensions {

    public static object _performSelector_Property(this object obj, string propertyName) {

        Type magicType = obj.GetType();
        PropertyInfo pi = magicType.GetProperty(propertyName,
        BindingFlags.Public | BindingFlags.NonPublic |
        BindingFlags.Instance | BindingFlags.Static |
        BindingFlags.DeclaredOnly);

        MethodInfo getMethod = pi.GetGetMethod();
        object result = getMethod.Invoke(obj, null);

        return result;
    }
}

namespace Gtk {

	public class TreeViewColumnEx : TreeViewColumn {

		public String bindingPropertyName = "";

		public CellRendererText _mkCellRendererText(string title = "") {
            this.Title = title;
            Gtk.CellRendererText CellRendererText1 = new Gtk.CellRendererText();
            this.PackStart(CellRendererText1, true);

            return CellRendererText1;
        }

        public CellRendererPixbuf _mkCellRendererPixbuf(string title = "") {
            this.Title = title;
            Gtk.CellRendererPixbuf CellRendererPixbuf1 = new Gtk.CellRendererPixbuf();
            this.PackStart(CellRendererPixbuf1, true);
            return CellRendererPixbuf1;
        }

        public CellRendererToggle _mkCellRendererToggle(string title = "") {
            this.Title = title;
            Gtk.CellRendererToggle CellRendererToggle1 = new Gtk.CellRendererToggle();
            this.PackStart(CellRendererToggle1, true);
            return CellRendererToggle1;
        }

        public CellRendererProgress _mkCellRendererProgress(string title = "") {
            this.Title = title;
            Gtk.CellRendererProgress CellRendererProgress1 = new Gtk.CellRendererProgress();
            this.PackStart(CellRendererProgress1, true);
            return CellRendererProgress1;
        }
		        

        public void _mkBinding() {
            if(this.Cells.Length > 0) {
                this.SetCellDataFunc(this.Cells[0], new Gtk.TreeCellDataFunc(_RenderCellDo));
            }
        }

		private void _RenderCellDo(Gtk.TreeViewColumn column, Gtk.CellRenderer cell, Gtk.TreeModel model, Gtk.TreeIter iter) {

			if(!(column is TreeViewColumnEx)) {
                return;
			}
            TreeViewColumnEx columnt1 = (column as TreeViewColumnEx);

			if(columnt1.bindingPropertyName == "" || columnt1.bindingPropertyName == null) {
                Console.WriteLine("PropertyNameがない");
                return;
			}

            object song = (object)model.GetValue(iter, 0);

            object value = song._performSelector_Property(columnt1.bindingPropertyName);

            if ( cell is Gtk.CellRendererText && (value is String)) {
                (cell as Gtk.CellRendererText).Text = value as String;
            } else if(cell is Gtk.CellRendererPixbuf && (value is String)) {
                (cell as Gtk.CellRendererPixbuf).Pixbuf = new Pixbuf(null, (value as String));
            } else if(cell is Gtk.CellRendererToggle && (value is String)) {
                (cell as Gtk.CellRendererToggle).Active = Convert.ToBoolean((value is String));
            } else if(cell is Gtk.CellRendererProgress && (value is String)) {
                (cell as Gtk.CellRendererProgress).Value = Convert.ToInt32((value is String));
            } else if(cell is Gtk.CellRendererPixbuf && (value is byte[])) {
                (cell as Gtk.CellRendererPixbuf).Pixbuf = new Pixbuf((byte[])value);
            } else if(cell is Gtk.CellRendererToggle && (value is Boolean)) {
                (cell as Gtk.CellRendererToggle).Active = (Boolean)value;
            } else if(cell is Gtk.CellRendererProgress && (value is int)) {
                (cell as Gtk.CellRendererProgress).Value = (int)value;
            }

        }

    }


}
