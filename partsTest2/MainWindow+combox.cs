using System;
using Gdk;
using Gtk;

public partial class MainWindow {

	void _mkComoboBox() {

		combobox20._mkCellRendererText("Artist");

		combobox20._mkBinding();

		combobox20.Model = musicListStore;

	}


}
