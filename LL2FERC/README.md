# Latitude and Longitude To Flinn-Engdahl Regions Code
![Nuget](https://img.shields.io/nuget/v/LL2FERC)
![Nuget](https://img.shields.io/nuget/dt/LL2FERC)
![GitHub last commit](https://img.shields.io/github/last-commit/Ichihai1415/LL2FERC)
![GitHub Release Date](https://img.shields.io/github/release-date/Ichihai1415/LL2FERC)
![GitHub issues](https://img.shields.io/github/issues/Ichihai1415/LL2FERC)

緯度と経度からFlinn-Engdahl regions code、Flinn-Engdahl regions codeから日本語名称・英語名称への変換ができます。<br>
お知らせ:コードは英語で書かれていますが、READMEは日本語で書かれています。

This library can convert from latitude and longitude to Flinn-Engdahl region codes, and from Flinn-Engdahl region codes to Japanese and English names.<br>
Notice: The code is written in English, but the README is written in Japanese.

## データ

コード:[USGS Geoserve Regions Endpoint](https://earthquake.usgs.gov/ws/geoserve/regions.php)  取得:2023/04/29~4/30

日本語名称:[気象庁防災情報XMLフォーマット　技術資料　個別コード表](http://xml.kishou.go.jp/tec_material.html)  取得ファイル:20221118

英語名称:[Wikipedia - "Flinn-Engdahl regionalization"](https://en.wikipedia.org/wiki/Flinn-Engdahl_regionalization)  閲覧:2023/05/10

## インストール

- NuGetパッケージマネージャーで"LL2FERC"で検索

- PM> `NuGet\Install-Package LL2FERC`

- \> `dotnet add package LL2FERC`

## 使い方
(一部確認してないので動かないかもしれません)
```c#
//using LL2FERC;

double lat = 35.79;
double lon = 135.79;

int code = LL2FERC.GetCode(lat, lon);//コード

//コード->名称
string name_ja = LL2FERC.GetName_ja(code);//日本語名称
string name_en = LL2FERC.GetName_enUS(code);//英語名称

//緯度経度->名称
string name_ja = LL2FERC.GetName_ja(lat, lon);//日本語名称
string name_en = LL2FERC.GetName_enUS(lat, lon);//英語名称
```

`using static LL2FERC.LL2FERC;`とすることで以下のように省略できます。
```c#
int code = GetCode(lat, lon);//コード
```

元データリスト(上のコードで内部使用しているもの、readonly)のコピーの例(値を変えないなら参照でも可)(`using static LL2FERC.Datas;`で省略)
```c#
int[,] codes = (int[,])LL2FERC.Datas.Codes.Clone();//元のコード一覧　
var nameList_ja = new Dictionary<int, string>(LL2FERC.Datas.NameList_ja);//日本語名称一覧
var nameList_en = new Dictionary<int, string>(LL2FERC.Datas.NameList_enUS);//英語名称一覧
```

## その他
- [レポジトリ](https://github.com/Ichihai1415/LL2FERC/tree/release)に緯度経度グリッドでのコードのcsvデータ(`codes.csv`)があります。
- `namelist_{language}.csv`は
- 間違っているところ等あればissuesやDMなどで連絡してください。

## 更新履歴
### v1.3.0
2024/03/29

- **変数名・メゾット名等を変更しました。確認してください。**
- ソースファイルを分割

### v1.2.0
2023/10/08

- **クラス名を変更しました。確認してください。**
- 緯度経度から名称(日本語・英語)の変換を追加

### v1.1.1
2023/09/30

- **変数名・メゾット名等を変更しました。確認してください。**
- コードから日本語名称の変換を、気象庁と同じ文字に(以前までは半角化などをしていた)
- 変数名等コード・READMEの調整、コメント等の英文化

### v1.1.0
2023/05/10

- コードから名称(日本語・英語)の変換を追加

### v1.0.0
2023/04/30

- 緯度経度からコードへの変換を追加
