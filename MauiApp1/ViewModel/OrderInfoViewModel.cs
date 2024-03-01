
using Syncfusion.Maui.Data;
using System.Collections.ObjectModel;

namespace MauiApp1
{
    public class OrderInfoRepository 
    {

        private ObservableCollection<OrderInfo> orderInfo;

        public ObservableCollection<OrderInfo> OrderInfoCollection
        {
            get { return orderInfo; }
            set
            {
                this.orderInfo = value;
            }
        }
        public ObservableCollection<string> CustomerNames { get; set; }

        internal string[] NewCustomers = new string[] { "Emily Anderson", "William Thomas", "Jessica White", "Daniel Clark", "Olivia Jackson" };


        public OrderInfoRepository()
        {
            orderInfo = new ObservableCollection<OrderInfo>();
            this.GenerateOrders();
            CustomerNames = NewCustomers.ToObservableCollection();
        }

        public void GenerateOrders()
        {
            orderInfo.Add(new OrderInfo(1001, "Maria Anders", "Germany", "ALFKI", "Berlin", 15000));
            orderInfo.Add(new OrderInfo(1002, "Emma Johnson", "Mexico", "ANATR", "Mexico D.F.", 12000));
            orderInfo.Add(new OrderInfo(1003, "Andrea Rossi", "Mexico", "ANTON", "Mexico D.F.", 16000));
            orderInfo.Add(new OrderInfo(1004, "Thomas Hardy", "UK", "BERGS", "London", 14000));
            orderInfo.Add(new OrderInfo(1005, "Sophie Dubois", "Germany", "BLAUS", "Mannheim", 22000));
        }

    }
}
