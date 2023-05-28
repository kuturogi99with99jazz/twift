# .NET7とDockerによるWEBサービス

## フォルダ構成

### dev

開発関連フォルダ。ソースや開発用Dockerfileはここに配置する

### src

.NET7のソースフォルダ

### メモ

``` docker
# docker イメージ作成
docker build -t twift .
# docker コンテナ起動
docker run --name twift -p 5062:5062 -v ~/twift/dev/src:/twift/src -it twift
```

``` csharp
// 新規プロジェクト作成
dotnet new blazorserver -o src --no-https -f net7.0
// Razor コンポーネント作成
dotnet new razorcomponent -n Todo -o Pages
// デバッグ起動
// コンテナに入った状態で以下のコマンド
dotnet watch run --urls http://*:5062
// 終わらせるには
ctrl+C
```