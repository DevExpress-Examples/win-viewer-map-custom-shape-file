# How to Custom Maps for Map Dashboard Item in WinForms Viewer

The following example shows how to load a .shp file to provide a custom map for the Choropleth Map dashboard item.

![](img\map.png)

DevExpress Dashboard uses a **Shapefile** vector format to provide custom maps. Commonly, this format includes two file types:

- **.shp** file - holds map shapes (points/lines/polygons);
- **.dbf** file - contains attributes for each shape.

Follow the steps below to load the existing shapefile in code:

- Set the [MapDashboardItem.Area](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.MapDashboardItem.Area) property to **Custom** and use the [MapDashboardItem.CustomShapefile](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.MapDashboardItem.CustomShapefile) property.
- Create a [CustomShapefileData](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.CustomShapefileData) object.
- Specify its [CustomShapefileData.ShapeData](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.CustomShapefileData.ShapeData) property and [CustomShapefileData.AttributeData](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.CustomShapefileData.AttributeData) property (optional).
- Assign this object to the [CustomShapefile.Data](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.CustomShapefile.Data) property.

If you use the [CustomShapefile.Url](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.CustomShapefile.Url) property to open a map, the dashboard XML definition will contain the path to a map shapefile. If you open the map with the [CustomShapefile.Data](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.CustomShapefile.Data) property, the dashboard XML definition will contain the map itself.

See [Custom Maps](https://docs.devexpress.com/Dashboard/16478/create-dashboards/create-dashboards-in-the-winforms-designer/designing-dashboard-items/choropleth-map/providing-maps#custom-maps) for details.