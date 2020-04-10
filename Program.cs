using System;
using Gtk;
using Mono.Data.Sqlite;
using Dapper;
using DapperExtensions;
using System.Collections.Generic;
using System.Diagnostics;

namespace sqliteTest1 {
	class MainClass {

		public static void Main(string[] args) {

            _sqliteTest();            _dapperTest();            _dapperExtensionTest();            _pythonTest();

        }


        static public void _pythonTest() {

            //VisualStudioが利用しているインタープリターのパス
            var pythonInterpreterPath = @"/usr/local/bin/python";

            //「1. Python側を実装」にて保存したスクリプトのパス
            var pythonScriptPath = @"パス　/test.py";            var arguments = new List<string>            {            pythonScriptPath ,            "20",   //第1引数            "30"    //第2引数        };            var process = new Process() {                StartInfo = new ProcessStartInfo(pythonInterpreterPath) {                    UseShellExecute = false,                    RedirectStandardOutput = true,                    Arguments = string.Join(" ", arguments),                },            };            process.Start();

            //python側でprintした内容を取得
            var sr = process.StandardOutput;            var result = sr.ReadLine();            process.WaitForExit();            process.Close();            Console.WriteLine("Result is ... " + result);        }        static public void _dapperExtensionTest() {

            //Sql文を　[testTable].[test_id]から　[test_id]に変更する
            DapperExtensions.DapperExtensions.SqlDialect = new DapperExtensions.Sql.SqliteDialect();

            Mono.Data.Sqlite.SqliteConnection connection = new Mono.Data.Sqlite.SqliteConnection();            connection.ConnectionString = @"Data Source=パス　/test.sqlite";            connection.Open();            testTable testTable1 = new testTable();
            testTable1.name = "aaaaaa111";           
            try {
                connection.Insert<testTable>(testTable1);
            } catch(Exception en) {
                Console.WriteLine(en.Message);
            }            var qurey = "select * from testTable;";            var result = connection.QueryFirst<testTable>(qurey);            result.name += "qqqq111";			try {
                connection.Update<testTable>(result);
            } catch(Exception en) {
                Console.WriteLine(en.Message);
			}            connection.Close();        }        static public void _dapperTest() {            Mono.Data.Sqlite.SqliteConnection connection = new Mono.Data.Sqlite.SqliteConnection();             connection.ConnectionString = @"Data Source=パス　/test.sqlite";            connection.Open();            var qurey = "select * from testTable;";            var result = connection.Query<testTable>(qurey);            foreach(var p in result) {                Console.WriteLine("ID:" + p.test_id + " 名称:" + p.name);            }

            connection.Close();        }        static public void _sqliteTest() {            Mono.Data.Sqlite.SqliteConnection connection = new Mono.Data.Sqlite.SqliteConnection();            Mono.Data.Sqlite.SqliteCommand command = new Mono.Data.Sqlite.SqliteCommand();


            // 接続します。
            connection.ConnectionString = @"Data Source=パス　/sqliteTest1/test.sqlite";            connection.Open();

            // SELECT文を設定します。
            command.CommandText = "select * from testTable;";            command.Connection = connection;

            // SQLを実行します。
            Mono.Data.Sqlite.SqliteDataReader reader = command.ExecuteReader();            while(reader.Read()) {                var id = reader.GetValue(0);                var name = reader.GetValue(1);                Console.WriteLine("ID:" + id + " 名称:" + name);            }            connection.Close();        }



    }
}
