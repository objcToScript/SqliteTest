using System;
using Gtk;

public partial class MainWindow : Gtk.Window {

	public MainWindow() : base(Gtk.WindowType.Toplevel) {
		Build();

		_mkDb();

		_mkDataView();

		_mkLable();

		_mkToglleBtn();

		_mkRadioBtn();

		_mkImage();

		_mkTextView();

		_mkSnipTest();

		_mkComoboBox();

		_mkTreeView();


	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a) {
		Application.Quit();
		a.RetVal = true;
	}
}
