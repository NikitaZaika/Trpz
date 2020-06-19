using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TRPZ.User_Interface
{
    class ViewModel : INotifyPropertyChanged
    {
        IModel model;
        public ViewModel(IModel model)
        {
            this.model = model;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private List<string> dishes;
        public List<string> Dishes
        {
            get => model.GetDishes();
            set
            {
                dishes = value;
            }
        }
        private List<string> clients;
        public List<string> Clients
        {
            get => model.GetClients();
            set
            {
                clients = value;
            }
        }

        private string dish;
        public string Dish
        {
            get
            {
                return dish;
            }
            set
            {
                dish = value;
            }
        }
        private string client;
        public string Client
        {
            get
            {
                return client;
            }
            set
            {
                client = value;
            }
        }
        private RelayCommand createOrder;
        public RelayCommand CreateOrder
        {
            get
            {
                return createOrder ?? (new RelayCommand(obj =>
                {
                    CreateOrderCommand();
                }));
            }
        }
        public void CreateOrderCommand()
        {
            model.CreateOrder(dish, client);
            OnPropertyChanged("Client");
            OnPropertyChanged("Dish");
        }
        private List<string> orders;
        public List<string> Orders
        {
            get => model.GetOrders();
            set
            {
                orders = value;
            }
        }
        private string order;
        public string Order
        {
            get
            {
                return order;
            }
            set
            {
                order = value;
            }
        }
    }
}
