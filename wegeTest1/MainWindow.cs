using System;
using Gtk;

public partial class MainWindow : Gtk.Window {
	public MainWindow() : base(Gtk.WindowType.Toplevel) {
		Build();

		ComboBox con = combowidget1.Combo;

	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a) {
		Application.Quit();
		a.RetVal = true;
	}
}
