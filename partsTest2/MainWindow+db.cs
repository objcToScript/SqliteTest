using System;
using System.Data;
using System.Collections;
using GLib;
using Gtk;
using Mono.Data.Sqlite;
using Dapper;
using DapperExtensions;
using System.Collections.Generic;


public partial class MainWindow {

	Mono.Data.Sqlite.SqliteConnection connection;
	IEnumerable<Song> resultArray;
	Gtk.ListStore musicListStore;

	void _mkDb() {

		try {
			DapperExtensions.DapperExtensions.SqlDialect = new DapperExtensions.Sql.SqliteDialect();

			connection = new Mono.Data.Sqlite.SqliteConnection();

			connection.ConnectionString = @"Data Source=./songData.sqlite";

			connection.Open();

		} catch (Exception en) {
			Console.WriteLine(en.Message);
		}

    }

	void _mkDataView() {

		musicListStore = new Gtk.ListStore(typeof(Song));

		var qurey = "select * from Song;";
		resultArray = connection.Query<Song>(qurey);

		foreach(Song song in resultArray) {
			musicListStore.AppendValues(song);
		}

	}

}


