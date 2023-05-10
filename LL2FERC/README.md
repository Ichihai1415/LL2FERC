# Latitude and Longitude To Flinn-Engdahl Regions Code
![Nuget](https://img.shields.io/nuget/v/LL2FERC)
![Nuget](https://img.shields.io/nuget/dt/LL2FERC)
![GitHub last commit](https://img.shields.io/github/last-commit/Ichihai1415/LL2FERC)
![GitHub Release Date](https://img.shields.io/github/release-date/Ichihai1415/LL2FERC)
![GitHub issues](https://img.shields.io/github/issues/Ichihai1415/LL2FERC)

緯度と経度からF-E regions code、F-E regions codeから日本語名称・英語名称への変換ができます。

This library can convert from latitude and longitude to F-E region codes, and from F-E region codes to Japanese and English names.

# データ

コード:[USGS Geoserve Regions Endpoint](https://earthquake.usgs.gov/ws/geoserve/regions.php) 取得:2023/04/29~4/30

日本語名称:[気象庁防災情報XMLフォーマット　技術資料　個別コード表](http://xml.kishou.go.jp/tec_material.html) 取得ファイル:20221118

英語名称:[Wikipedia - "Flinn-Engdahl regionalization"](https://en.wikipedia.org/wiki/Flinn-Engdahl_regionalization) 閲覧:2023/05/10

# インストール

- NuGetパッケージマネージャーで"LL2FERC"で検索

- PM> `NuGet\Install-Package LL2FERC`

- \> `dotnet add package LL2FERC`

# 使い方
```c#
//using LL2FERC;

int code = LL2FERCode.Code(Lat, Lon);

string Name_JP = LL2FERCode.Name_JP(code);

string Name_EN = LL2FERCode.Name_EN(code);
```

# 更新履歴
## v1.1.0
2023/05/10

コードから名称(日本語・英語)の変換を追加

## v1.0.0
2023/04/30

緯度経度からコードへの変換を追加