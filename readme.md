<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/193109389/19.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T828669)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
_Files to view:_
- [Form1.cs](https://github.com/DevExpress-Examples/win-viewer-map-custom-shape-file/blob/19.1.3%2B/CS/WindowsFormsMapCustomShape/Form1.cs)

# How to Provide Custom Maps for Map Dashboard Items in WinForms

The following example shows how to load a .shp file to provide a custom map for the Choropleth Map dashboard item.

![](img/map.png)

DevExpress Dashboard uses a **Shapefile** vector format to provide custom maps. Commonly, this format includes two file types:

- **.shp** file - holds map shapes (points/lines/polygons);
- **.dbf** file - contains attributes for each shape.

Follow the steps below to load the existing shapefile in code:

- Set the [MapDashboardItem.Area](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.MapDashboardItem.Area) property to **Custom** and use the [MapDashboardItem.CustomShapefile](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.MapDashboardItem.CustomShapefile) property.
- Create a [CustomShapefileData](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.CustomShapefileData) object.
- Specify its [CustomShapefileData.ShapeData](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.CustomShapefileData.ShapeData) property and [CustomShapefileData.AttributeData](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.CustomShapefileData.AttributeData) property (optional).
- Assign this object to the [CustomShapefile.Data](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.CustomShapefile.Data) property.

If you use the [CustomShapefile.Url](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.CustomShapefile.Url) property to open a map, the dashboard XML definition will contain the path to a map shapefile. If you open the map with the [CustomShapefile.Data](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.CustomShapefile.Data) property, the dashboard XML definition will contain the map itself.

## See Also
- [Custom Maps](https://docs.devexpress.com/Dashboard/16478/create-dashboards/create-dashboards-in-the-winforms-designer/designing-dashboard-items/choropleth-map/providing-maps#custom-maps)
