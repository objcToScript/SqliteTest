## SqliteTest or TreeViewTest

#### インストール

[GTKSharp](https://www.mono-project.com/download/stable/#download-lin)をインストールする

[MonoDevelop](https://www.monodevelop.com/download/#fndtn-download-lin-raspbian)をインストールする

Nugetからダウンロードするパッケージ

Dapper

DapperExtensions

Mono.Data.Sqlie


#### Macでは動いたがLinuxでうごかなった場合の対処のしかた

Linuxに[MonoDevelop](https://www.monodevelop.com/download/#fndtn-download-lin-raspbian)をインストールする

$ monodevelop

IDEが立ち上がる。VisualStudio形式のSINファイルを読み込む

デバッグする

#### Microsoft.CSharp.Core.targetsファイルがないエラー

“/home/pi/,cache/MonoDevelop/7.0/MSBuild/1068_1/Microsoft.CSharp.Core.targetsが見つかりませんでした。

と出た場合は

ソリューション　ー　参照　ー Microsoft.CSharpを追加や更新

それでもエラーが出る場合は

RaspberryPi ー 表示　ー 隠しフォルダを表示する
MSBuild / 以下複数フォルダがある場合は両方削除する
再度Microsoft.CSharpを追加
