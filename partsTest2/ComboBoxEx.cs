using System;
using System.Reflection;
using Gdk;
using Gtk;

namespace Gtk {

		public partial class CellRendererTextEx : Gtk.CellRendererText {
			public string BindingPropertyName = "";
		}

        public static partial class ComboxExtensions {

        static public Gtk.CellRendererText _mkCellRendererText(this ComboBox Combox1 ,string baindingName , string title = "") {
            Gtk.CellRendererTextEx CellRendererTextEx1 = new Gtk.CellRendererTextEx();
            CellRendererTextEx1.BindingPropertyName = baindingName;
            Combox1.PackStart(CellRendererTextEx1, true);
            return CellRendererTextEx1;
        }

        static public void _mkBinding(this ComboBox Combox1) {
            if(Combox1.Cells.Length > 1) {
                Combox1.SetCellDataFunc(Combox1.Cells[1], new Gtk.CellLayoutDataFunc(_RenderComboDo));
            }
        }

        static private void _RenderComboDo(
            Gtk.CellLayout cell_layout,
            Gtk.CellRenderer cell,
            Gtk.TreeModel model,
            Gtk.TreeIter iter) {

            if(!(cell is Gtk.CellRendererTextEx)) {
                return;
            }

            if((cell as Gtk.CellRendererTextEx).BindingPropertyName == "" ||
                (cell as Gtk.CellRendererTextEx).BindingPropertyName == null) {
                Console.WriteLine("PropertyNameがない");
                return;
            }

            object song = (object)model.GetValue(iter, 0);

            object value = song._performSelector_Property((cell as Gtk.CellRendererTextEx).BindingPropertyName);

            if(cell is Gtk.CellRendererText && (value is String)) {
                (cell as Gtk.CellRendererText).Text = value as String;
            } else if(cell is Gtk.CellRendererPixbuf && (value is String)) {
                (cell as Gtk.CellRendererPixbuf).Pixbuf = new Pixbuf((value as String));
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


