using System;
using System.Collections;
using GLib;
using Gtk;
using Mono.Data.Sqlite;
using Dapper;
using DapperExtensions;

public partial class MainWindow {

	void _mkTreeView() {

			Gtk.TreeViewColumnEx artistColumn = new Gtk.TreeViewColumnEx();
			artistColumn._mkCellRendererText();
			artistColumn.Sizing = TreeViewColumnSizing.Fixed;
			artistColumn.FixedWidth = 200;
			artistColumn.Title = "Artist";
		    artistColumn.bindingPropertyName = "Artist";

			Gtk.TreeViewColumnEx songColumn = new Gtk.TreeViewColumnEx();
			songColumn._mkCellRendererText();
			songColumn.Sizing = TreeViewColumnSizing.Fixed;
			songColumn.FixedWidth = 200;
			songColumn.Title = "Song Title";
			songColumn.bindingPropertyName = "Title";

			Gtk.TreeViewColumnEx deleteCheckColumn = new Gtk.TreeViewColumnEx();
			CellRendererToggle toggleCell = deleteCheckColumn._mkCellRendererToggle();
			deleteCheckColumn.Sizing = TreeViewColumnSizing.Fixed;
			deleteCheckColumn.FixedWidth = 50;
			deleteCheckColumn.Title = "削除";
			deleteCheckColumn.bindingPropertyName = "Effective";

			toggleCell.Toggled += delegate (object o, ToggledArgs args) {
				TreeIter iter;
				if(musicListStore.GetIterFromString(out iter, args.Path)) {

					Song Song1 = (Song)musicListStore.GetValue(iter, 0);
					Song1.Del = Song1.Del == true ? false : true;
					//Dapperで更新する
					try {
						connection.Update<Song>(Song1);
					} catch(Exception en) {
						Console.WriteLine(en.Message);
					}
				}
			};

			Gtk.TreeViewColumnEx updateColumn = new Gtk.TreeViewColumnEx();			
			updateColumn.Sizing = TreeViewColumnSizing.Fixed;
			updateColumn.FixedWidth = 50;
			updateColumn.Title = "有効";
			updateColumn.bindingPropertyName = "Del";
			CellRendererToggle toggleCell1 = updateColumn._mkCellRendererToggle();
			toggleCell1.Toggled += new ToggledHandler(UpdateToggled);

			treeview.AppendColumn(artistColumn);
			treeview.AppendColumn(songColumn);
			treeview.AppendColumn(updateColumn);
			treeview.AppendColumn(deleteCheckColumn);

			artistColumn._mkBinding();
			songColumn._mkBinding();
			deleteCheckColumn._mkBinding();
			updateColumn._mkBinding();

			this.ShowAll();

		}	

		private void UpdateToggled(object o, ToggledArgs args) {
			TreeIter iter;
			if(musicListStore.GetIterFromString(out iter, args.Path)) {

				Song Song1 = (Song)musicListStore.GetValue(iter, 0);
				Song1.Effective = Song1.Effective == true ? false : true;
				//Dapperで更新する
				try {
					connection.Update<Song>(Song1);
				} catch(Exception en) {
					Console.WriteLine(en.Message);
				}

			}
		}

}

