using System.ComponentModel;
using System;

namespace BindingToLINQ
{
    public class Product : INotifyPropertyChanged
    {
        public Product()
        {

        }

        public Product(int id, string description, double price)
        {
            this.id = id;
            this.description = description;
            this.price = price;
        }

        private int id;
        public int ID
        {
            get { return this.id; }
            set
            {
                this.id = value;
                NotifyPropertyChanged("ID");
            }
        }

        private string description;
        public string Description
        {
            get { return this.description; }
            set
            {
                this.description = value;
                NotifyPropertyChanged("Description");
            }
        }

        private double price;
        public double Price
        {
            get { return this.price; }
            set
            {
                this.price = value;
                NotifyPropertyChanged("Price");
            }
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String info)
        {

            OnPropertyChanged(new PropertyChangedEventArgs(info));

        }

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(e.PropertyName));
            }
        }

        #endregion
    }
}
