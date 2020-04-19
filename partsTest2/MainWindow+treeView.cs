using System;
using Gdk;
using Gtk;

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

		treeview2.AppendColumn(artistColumn);
		treeview2.AppendColumn(songColumn);

		artistColumn._mkBinding();
		songColumn._mkBinding();

		treeview2.Model = musicListStore;

		this.ShowAll();

	}




}
