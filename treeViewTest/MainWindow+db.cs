using System;
using System.Data;
using System.Collections;
using GLib;
using Gtk;
using Mono.Data.Sqlite;
using Dapper;
using DapperExtensions;
using System.Collections.Generic;

public partial class MainWindow  {

	Mono.Data.Sqlite.SqliteConnection connection;
	IEnumerable<Song> resultArray;

	void _mkDb() {

        DapperExtensions.DapperExtensions.SqlDialect = new DapperExtensions.Sql.SqliteDialect();

		connection = new Mono.Data.Sqlite.SqliteConnection();

		connection.ConnectionString = @"Data Source=パス/songData.sqlite";

        connection.Open();

    }

	void _mkDataView() {

		var qurey = "select * from Song;";
		resultArray = connection.Query<Song>(qurey);

		musicListStore = new Gtk.ListStore(typeof(Song));

		foreach(Song song in resultArray) {
			musicListStore.AppendValues(song);
		}

		treeview.Model = musicListStore;

	}

}


