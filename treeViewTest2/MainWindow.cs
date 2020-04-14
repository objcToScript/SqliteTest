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

		try {
			_mkDb();
			_mkDataView();
			_mkTreeView();

		} catch(Exception en) {

			clsFile._sharedObject()._addSave("./errorLog.txt", en.Message + "¥n");

		}
	
	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a) {
		Application.Quit();
		a.RetVal = true;
	}


	protected void OnReNewBtnClicked(object sender, EventArgs e) {

		TreeIter iter;
	}

}