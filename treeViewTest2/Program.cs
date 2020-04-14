using System;
using Gtk;
using Mono.Data.Sqlite;
using Dapper;
using DapperExtensions;

namespace treeViewTest {
	class MainClass {
		public static void Main(string[] args) {

			try {

				clsFile._sharedObject()._addSave("./errorLog.txt","aaaaaaaaa");
				Application.Init();
				MainWindow win = new MainWindow();
				win.Show();
				Application.Run();

			} catch(Exception en) {

				clsFile._sharedObject()._addSave("./errorLog.txt", en.Message +  "¥n");

			}

		}
	}
}
