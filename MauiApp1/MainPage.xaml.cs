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
