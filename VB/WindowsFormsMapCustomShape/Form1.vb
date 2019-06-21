Imports DevExpress.DashboardCommon
Imports DevExpress.DataAccess.Excel
Imports DevExpress.XtraEditors
Imports System.IO

Namespace WindowsFormsMapCustomShape
	Partial Public Class Form1
		Inherits XtraForm

		Public Sub New()
			InitializeComponent()

			Dim dashboard As New Dashboard()

			'Create an Excel data source.
			Dim excelDataSource As New DashboardExcelDataSource()
			excelDataSource.FileName = "..\..\Data\Sales.xlsx"
			Dim worksheetSettings As New ExcelWorksheetSettings("Sheet1", "A1:I4166")
			excelDataSource.SourceOptions = New ExcelSourceOptions(worksheetSettings)
			excelDataSource.Fill()
			dashboard.DataSources.Add(excelDataSource)

			' Create a Choropleth Map dashboard item.
			Dim map As New ChoroplethMapDashboardItem()
			map.Name = "Choropleth Map"
			map.DataSource = excelDataSource
			map.Legend.Visible = True
			map.ShapeTitleAttributeName = "NAME"
			map.AttributeName = "NAME"
			map.AttributeDimension = New Dimension("State")
			Dim revenueYTDMap As New ValueMap(New Measure("RevenueYTD (Sum)"))
			map.Maps.Add(revenueYTDMap)

			' Loads a custom shape file to the map.
			map.Area = ShapefileArea.Custom
			Dim data As New CustomShapefileData()
			data.ShapeData = File.ReadAllBytes("..\..\Map\USA.shp")
			data.AttributeData = File.ReadAllBytes("..\..\Map\USA.dbf")
			map.CustomShapefile.Data = data

			dashboard.Items.Add(map)
			dashboardViewer.Dashboard = dashboard
		End Sub
	End Class
End Namespace
