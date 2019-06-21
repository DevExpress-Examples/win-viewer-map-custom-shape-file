using DevExpress.DashboardCommon;
using DevExpress.DataAccess.Excel;
using DevExpress.XtraEditors;
using System.IO;

namespace WindowsFormsMapCustomShape
{
    public partial class Form1: XtraForm
    {
        public Form1() {
            InitializeComponent();

            Dashboard dashboard = new Dashboard();

            //Create an Excel data source.
            DashboardExcelDataSource excelDataSource = new DashboardExcelDataSource();
            excelDataSource.FileName = @"..\..\Data\Sales.xlsx";
            ExcelWorksheetSettings worksheetSettings = new ExcelWorksheetSettings("Sheet1", "A1:I4166");
            excelDataSource.SourceOptions = new ExcelSourceOptions(worksheetSettings);
            excelDataSource.Fill();
            dashboard.DataSources.Add(excelDataSource);

            // Create a Choropleth Map dashboard item.
            ChoroplethMapDashboardItem map = new ChoroplethMapDashboardItem();
            map.Name = "Choropleth Map";
            map.DataSource = excelDataSource;
            map.Legend.Visible = true;
            map.ShapeTitleAttributeName = "NAME";
            map.AttributeName = "NAME";
            map.AttributeDimension = new Dimension("State");
            ValueMap revenueYTDMap = new ValueMap(new Measure("RevenueYTD (Sum)"));
            map.Maps.Add(revenueYTDMap);

            // Loads a custom shape file to the map.
            map.Area = ShapefileArea.Custom;
            CustomShapefileData data = new CustomShapefileData();
            data.ShapeData = File.ReadAllBytes(@"..\..\Map\USA.shp");
            data.AttributeData = File.ReadAllBytes(@"..\..\Map\USA.dbf");
            map.CustomShapefile.Data = data;

            dashboard.Items.Add(map);
            dashboardViewer.Dashboard = dashboard;
        }
    }
}
