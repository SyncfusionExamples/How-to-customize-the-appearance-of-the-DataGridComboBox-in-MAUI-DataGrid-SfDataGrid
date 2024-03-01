using Syncfusion.Maui.Data;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MauiApp1
{
    public class OrderInfo : INotifyPropertyChanged
    {
        private int? orderID;
        private string? customerID;
        private string? customer;
        private string? shipCity;
        private string? shipCountry;
        private double? price;

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        
        public int? OrderID
        {
            get { return orderID; }
            set
            {
                this.orderID = value;
                OnPropertyChanged(nameof(OrderID));
            }


        }

        public string? CustomerID
        {
            get { return customerID; }
            set
            {
                this.customerID = value;
                OnPropertyChanged(nameof(CustomerID));
            }
        }

        public string? ShipCountry
        {
            get { return shipCountry; }
            set
            {
                this.shipCountry = value;
                OnPropertyChanged(nameof(ShipCountry));
            }
        }

        public string? Customer
        {
            get { return this.customer; }
            set
            {
                this.customer = value;
                OnPropertyChanged(nameof(Customer));
            }
        }

        public string? ShipCity
        {
            get { return shipCity; }
            set
            {
                this.shipCity = value;
                OnPropertyChanged(nameof(ShipCity));
            }
        }

        public double? Price
        {
            get { return price; }
            set
            {
                this.price = value;
                OnPropertyChanged(nameof(Price));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="customer"></param>
        /// <param name="country"></param>
        /// <param name="customerId"></param>
        /// <param name="shipCity"></param>
        /// <param name="price"></param>
        public OrderInfo(int? orderId, string? customer, string? country, string? customerId, string? shipCity, double? price)
        {
            this.OrderID = orderId;
            this.Customer = customer;
            this.ShipCountry = country;
            this.CustomerID = customerId;
            this.ShipCity = shipCity;
            this.Price = price;
        }
    }
}
