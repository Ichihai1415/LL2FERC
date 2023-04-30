# LatLonToFlinnEngdahlRegionsCode

[USGS Geoserve Regions Endpoint](https://earthquake.usgs.gov/ws/geoserve/regions.php)から1度毎(89.5, -179.5 ...)に取得したものです。(取得日:2023/04/29~4/30)

# インストール

- NuGetパッケージマネージャーで"LL2FERC"で検索

- PM> `NuGet\Install-Package LL2FERC -Version 1.0.0`

- \> `dotnet add package LL2FERC --version 1.0.0`

# 使い方
```c#
//using LL2FERC;

int code = LL2FERCode.Code(Lat, Lon);
```

# バージョン

## v1.0.0
2023/04/30
