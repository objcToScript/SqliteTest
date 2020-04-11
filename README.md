## SqliteTest or TreeViewTest

#### インストール

Nugetからダウンロードするパッケージ

Dapper

DapperExtensions

Mono.Data.Sqlie

Sqliteファイルのパスを設定してください

connection = new Mono.Data.Sqlite.SqliteConnection();

connection.ConnectionString = @"Data Source=パス/songData.sqlite";


##### Macでは動いたがLinuxでうごかなった場合の対処のしかた

Linuxに[MonoDevelop](https://www.monodevelop.com/download/#fndtn-download-lin-raspbian)をインストールする

$ monodevelop

IDEが立ち上がる。VisualStudio形式のSINファイルを読み込む

デバッグする
