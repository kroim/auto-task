using System.ComponentModel;
using System;
namespace BusinessObjects
{
    public class Product : INotifyPropertyChanged
    {
        public Product()
        {

        }

        public Product(int id, string description)
        {
            this.id = id;
            this.description = description;
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
