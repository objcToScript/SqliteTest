﻿using System;
using Gtk;
using Mono.Data.Sqlite;
using Dapper;
using DapperExtensions;
using System.Collections.Generic;
using System.Diagnostics;

namespace sqliteTest1 {
	class MainClass {

		public static void Main(string[] args) {

            _sqliteTest();

        }


        static public void _pythonTest() {

            //VisualStudioが利用しているインタープリターのパス
            var pythonInterpreterPath = @"/usr/local/bin/python";

            //「1. Python側を実装」にて保存したスクリプトのパス
            var pythonScriptPath = @"パス　/test.py";

            //python側でprintした内容を取得
            var sr = process.StandardOutput;

            //Sql文を　[testTable].[test_id]から　[test_id]に変更する
            DapperExtensions.DapperExtensions.SqlDialect = new DapperExtensions.Sql.SqliteDialect();

            Mono.Data.Sqlite.SqliteConnection connection = new Mono.Data.Sqlite.SqliteConnection();
            testTable1.name = "aaaaaa111";

            connection.Close();


            // 接続します。
            connection.ConnectionString = @"Data Source=パス　/test.sqlite";

            // SELECT文を設定します。
            command.CommandText = "select * from testTable;";

            // SQLを実行します。
            Mono.Data.Sqlite.SqliteDataReader reader = command.ExecuteReader();



    }
}