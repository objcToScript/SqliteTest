## SqliteTest

####インストール

Nugetからダウンロードするパッケージ

Dapper
DapperExtensions
Mono.Data.Sqlie

Sqliteファイルのパスを設定してください

connection = new Mono.Data.Sqlite.SqliteConnection();
connection.ConnectionString = @"Data Source=パス/songData.sqlite";

