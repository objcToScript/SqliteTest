using System;
using Gtk;
using Mono.Data.Sqlite;
using Dapper;
using DapperExtensions;

namespace treeViewTest {
	class MainClass {
		public static void Main(string[] args) {

			DapperExtensions.DapperExtensions.SqlDialect = new DapperExtensions.Sql.SqliteDialect();

			Application.Init();
			MainWindow win = new MainWindow();
			win.Show();
			Application.Run();
		}
	}
}
