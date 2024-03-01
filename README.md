# How to customize the appearance of the DataGridComboBox in MAUI DataGrid (SfDataGrid)?

This article demonstrates how to customize the appearance of the [DataGridComboBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridComboBoxColumn.html) within a .NET [MAUI DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid).

The .NET MAUI DataGrid (SfDataGrid) provides flexibility in customizing the appearance of the DataGridComboBox at the sample level by overriding the [DataGridComboBoxRenderer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridComboBoxRenderer.html).

To achieve this customization, follow these steps:

Create a class named CustomDataGridComboBoxRenderer that inherits from `DataGridComboBoxRenderer`.
Inside the CustomDataGridComboBoxRenderer class, set the desired properties for the SfComboBox view within the OnInitializeEditView method.
Register the custom `DataGridComboBoxRenderer` in the SfDataGrid.CellRenderers collection. This involves removing the existing entry with the corresponding key from the collection and adding a new entry with the same key, along with an instance of the custom renderer.

```xml
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
            xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
            xmlns:local="clr-namespace:MauiApp1"
            xmlns:dataGrid="clr-namespace:Syncfusion.Maui.DataGrid;assembly=Syncfusion.Maui.DataGrid"
            x:Class="MauiApp1.MainPage">

   <ContentPage.BindingContext>
       <local:OrderInfoRepository x:Name="viewModel"/>
   </ContentPage.BindingContext>

   <dataGrid:SfDataGrid x:Name="dataGrid"
                        AutoGenerateColumnsMode="None"
                        ColumnWidthMode="Auto"
                        SelectionMode="Single"
                        AllowEditing="True"
                        ItemsSource="{Binding OrderInfoCollection}">
       <dataGrid:SfDataGrid.Columns>
           <dataGrid:DataGridTextColumn MappingName="OrderID" 
                                        HeaderText="Order ID"/>
           <dataGrid:DataGridTextColumn MappingName="CustomerID" 
                                        HeaderText="Customer ID"/>
           <dataGrid:DataGridComboBoxColumn MappingName="Customer" 
                                            HeaderText="Customer Name"
                                            HeaderTextAlignment="Start"
                                            Width="200"
                                            ItemsSource="{Binding CustomerNames}"/>
           <dataGrid:DataGridTextColumn MappingName="ShipCity" 
                                        HeaderText="Ship City"/>
           <dataGrid:DataGridTextColumn MappingName="ShipCountry" 
                                        HeaderText="Ship Country"/>
           <dataGrid:DataGridTextColumn MappingName="Price" 
                                        HeaderText="Total Price"/>
       </dataGrid:SfDataGrid.Columns>
   </dataGrid:SfDataGrid>
</ContentPage>

```

```c#
using Syncfusion.Maui.DataGrid;
using Syncfusion.Maui.Inputs;

namespace MauiApp1
{
   public partial class MainPage : ContentPage
   {
       public MainPage()
       {
           InitializeComponent();
           dataGrid.CellRenderers.Remove("ComboBox");
           dataGrid.CellRenderers.Add("ComboBox", new CustomDataGridComboBoxRenderer());
       }
   }

   public class CustomDataGridComboBoxRenderer : DataGridComboBoxRenderer
   {
       public override void OnInitializeEditView(DataColumnBase dataColumn, SfComboBox view)
       {
           base.OnInitializeEditView(dataColumn, view);

           view.ClearButtonIconColor = Colors.Red;
           view.DropDownIconColor = Colors.Purple;
           view.TextColor = Colors.DeepPink;
           view.Placeholder = "Select a value";
           view.PlaceholderColor = Colors.DarkMagenta;
           view.TextColor = Colors.DarkViolet;
       }
   }
}

```

