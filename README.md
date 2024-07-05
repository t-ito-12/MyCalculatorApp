# 自作電卓アプリ
## 概要
C# Windows Forms .NET8.0で作成した電卓アプリです。MVVMパターンで実装しています  
![image](https://github.com/t-ito-12/MyCalculatorApp/assets/87246215/347f985b-e7c7-4f6d-b05a-30c15a3718dc)
## 仕様
- 基本動作はWindows搭載の電卓アプリに準拠しています
- 小数点以下5桁まで操作可能です
- 各操作はログに出力されます
  - Debugビルドの場合: デバッグコンソール
  - Releaseビルドの場合: 実行ファイルと同階層に"log.txt"として出力
## 使用技術一覧
- C# 12.0  
- .NET 8.0.6
## 使用パッケージ一覧
- CommunityToolkit.Mvvm 8.2.2: <https://www.nuget.org/packages/CommunityToolkit.Mvvm/8.2.2?_src=template>  
- log4net 2.0.17: <https://www.nuget.org/packages/log4net/2.0.17?_src=template>
## 開発環境
- VisualStudio2022
## 動作確認済み環境  
Windows11  
