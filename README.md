## SqliteTest or TreeViewTest

###Macで開発する

[VisualStudioMacをインストールする](https://docs.microsoft.com/ja-jp/visualstudio/mac/installation?view=vsmac-2019)

#### Linuxで開発する

[MonoDevelopをインストールする](https://www.monodevelop.com/download/#fndtn-download-lin-raspbian)をインストールする

[GTKSharp](https://www.mono-project.com/download/stable/#download-lin)をインストールする


#### Nugetからダウンロードするパッケージ

Dapper

DapperExtensions

Mono.Data.Sqlie


#### Macでは動いたがLinuxでうごかなった場合の対処の仕方

VisualStudio形式のSINはMacWinLinuxで互換性あり

MonoDevelopを起動する

$ monodevelop

VisualStudioをSinファイルを読み込みデバッグする

#### LinuxのMonoDevelopの必須設定

Microsoft.CSharp.Core.targetsファイルがないエラー

“/home/pi/,cache/MonoDevelop/7.0/MSBuild/1068_1/Microsoft.CSharp.Core.targetsが見つかりませんでした。と出た場合は

#### MonoDevelopの設定画面　プロジェクト　ー　ビルド
**「xbuildの代わりにMSBuildでビルドする」を無効にする**

無効にすること

