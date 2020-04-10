using System;
using System.Collections;
using GLib;
using Gtk;
using Mono.Data.Sqlite;
using Dapper;
using DapperExtensions;

public partial class MainWindow {

	void _mkTreeView() {

			Gtk.TreeViewColumn artistColumn = new Gtk.TreeViewColumn();
			artistColumn.Sizing = TreeViewColumnSizing.Fixed;
			artistColumn.FixedWidth = 200;
			artistColumn.Title = "Artist";
			Gtk.CellRendererText artistNameCell = new Gtk.CellRendererText();
			artistColumn.PackStart(artistNameCell, true);

			Gtk.TreeViewColumn songColumn = new Gtk.TreeViewColumn();
			songColumn.Sizing = TreeViewColumnSizing.Fixed;
			songColumn.FixedWidth = 200;
			songColumn.Title = "Song Title";
			Gtk.CellRendererText songTitleCell = new Gtk.CellRendererText();
			songColumn.PackStart(songTitleCell, true);

		Gtk.TreeViewColumn deleteCheckColumn = new Gtk.TreeViewColumn();
		deleteCheckColumn.Sizing = TreeViewColumnSizing.Fixed;
		deleteCheckColumn.FixedWidth = 50;
		deleteCheckColumn.Title = "削除";
			var toggleCell = new CellRendererToggle();
		deleteCheckColumn.PackStart(toggleCell, true);

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

			Gtk.TreeViewColumn updateColumn = new Gtk.TreeViewColumn();
			updateColumn.Sizing = TreeViewColumnSizing.Fixed;
			updateColumn.FixedWidth = 50;
			updateColumn.Title = "有効";
			var toggleCell1 = new CellRendererToggle();
			updateColumn.PackStart(toggleCell1, true);
			toggleCell1.Toggled += new ToggledHandler(UpdateToggled);

			treeview.AppendColumn(artistColumn);
			treeview.AppendColumn(songColumn);
			treeview.AppendColumn(updateColumn);
			treeview.AppendColumn(deleteCheckColumn);

			artistColumn.SetCellDataFunc(artistColumn.Cells[0], new Gtk.TreeCellDataFunc(RenderArtistName));
			songColumn.SetCellDataFunc(songColumn.Cells[0], new Gtk.TreeCellDataFunc(RenderSongTitle));
			deleteCheckColumn.SetCellDataFunc(deleteCheckColumn.Cells[0], new Gtk.TreeCellDataFunc(RenderCheck));
			updateColumn.SetCellDataFunc(updateColumn.Cells[0], new Gtk.TreeCellDataFunc(RenderUpdateCheck));

			this.ShowAll();

		}

		private void RenderArtistName(Gtk.TreeViewColumn column, Gtk.CellRenderer cell, Gtk.TreeModel model, Gtk.TreeIter iter) {
			Song song = (Song)model.GetValue(iter, 0);
			(cell as Gtk.CellRendererText).Text = song.Artist;
		}

		private void RenderSongTitle(Gtk.TreeViewColumn column, Gtk.CellRenderer cell, Gtk.TreeModel model, Gtk.TreeIter iter) {
			Song song = (Song)model.GetValue(iter, 0);
			(cell as Gtk.CellRendererText).Text = song.Title;
		}

		private void RenderCheck(Gtk.TreeViewColumn column, Gtk.CellRenderer cell, Gtk.TreeModel model, Gtk.TreeIter iter) {
			Song song = (Song)model.GetValue(iter, 0);
			(cell as Gtk.CellRendererToggle).Active = song.Del;
		}

		private void RenderUpdateCheck(Gtk.TreeViewColumn column, Gtk.CellRenderer cell, Gtk.TreeModel model, Gtk.TreeIter iter) {
			Song song = (Song)model.GetValue(iter, 0);
			(cell as Gtk.CellRendererToggle).Active = song.Effective;
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

