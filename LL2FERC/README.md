# LatLonToFlinnEngdahlRegionsCode

[USGS Geoserve Regions Endpoint](https://earthquake.usgs.gov/ws/geoserve/regions.php)から1度毎(89.5, -179.5 ...)に取得したものです。(取得日:2023/04/29~4/30)

# 使い方
```c#
//using LL2FERC;

int code = LL2FERCode.Code(Lat, Lon);
```