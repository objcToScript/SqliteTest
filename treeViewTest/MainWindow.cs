﻿using System;
using System.Collections;
using GLib;
using Dapper;
using DapperExtensions;
using Gtk;

public partial class MainWindow : Gtk.Window {

	Gtk.ListStore musicListStore;

	public MainWindow() : base(Gtk.WindowType.Toplevel) {
		Build();		

		_mkDb();
		_mkDataView();
		_mkTreeView();
	
	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a) {
		Application.Quit();
		a.RetVal = true;
	}


	protected void OnReNewBtnClicked(object sender, EventArgs e) {

		TreeIter iter;
	}

}