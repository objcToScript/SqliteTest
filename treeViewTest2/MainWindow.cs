using System;
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


	protected void OnReNewBtnClicked(object sender, EventArgs e) {		artistText.Buffer.Text = "";		titleText.Buffer.Text = "";		effectiveBtn.Active = false;		artistText.GrabFocus();		_mkDataView();	}	protected void OnTreeviewRowActivated(object o, RowActivatedArgs args) {

		TreeIter iter;		if(treeview.Model.GetIter(out iter, args.Path)) {			Song Song1 = (Song)treeview.Model.GetValue(iter, 0);			artistText.Buffer.Text = Song1.Artist;			titleText.Buffer.Text = Song1.Title;			effectiveBtn.Active = Song1.Effective;		}
	}	protected void OnMakeBtnClicked(object sender, EventArgs e) {		if(artistText.Buffer.Text != "" && titleText.Buffer.Text != "") {			Song Song1 = new Song();			Song1.Artist = artistText.Buffer.Text;			Song1.Title = titleText.Buffer.Text;			Song1.Effective = effectiveBtn.Active;			try {				connection.Insert<Song>(Song1);			} catch(Exception en) {				Console.WriteLine(en.Message);			}			artistText.Buffer.Text = "";			titleText.Buffer.Text = "";			effectiveBtn.Active = false;			_mkDataView();		}	}	protected void OnUpdateBtnClicked(object sender, EventArgs e) {		foreach(Song song in resultArray) {			try {				connection.Update<Song>(song);			} catch(Exception en) {				Console.WriteLine(en.Message);			}		}		_mkDataView();	}	protected void OnDeleteBtnClicked(object sender, EventArgs e) {		foreach(Song song in resultArray) {			if(Convert.ToBoolean(song.Del)) {				try {					connection.Delete<Song>(song);				} catch(Exception en) {					Console.WriteLine(en.Message);				}			}		}		_mkDataView();	}

}
