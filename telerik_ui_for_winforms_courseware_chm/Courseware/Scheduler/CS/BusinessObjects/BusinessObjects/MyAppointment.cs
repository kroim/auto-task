using System;
using System.ComponentModel;

namespace BusinessObjects
{
    public class MyAppointment : INotifyPropertyChanged
    {
        private DateTime start = DateTime.Now;
        private DateTime end = DateTime.Now;
        private string subject = string.Empty;
        private string description = string.Empty;
        private string location = string.Empty;
        private Guid id = Guid.NewGuid();

        public MyAppointment()
        {
        }

        public MyAppointment(DateTime start, DateTime end, string subject, string description, string location)
        {
            this.start = start;
            this.end = end;
            this.subject = subject;
            this.description = description;
            this.location = location;
        }

        public Guid Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (this.id != value)
                {
                    this.id = value;
                    this.OnPropertyChanged("Id");
                }
            }
        }

        public DateTime Start
        {
            get
            {
                return this.start;
            }
            set
            {
                if (this.start != value)
                {
                    this.start = value;
                    this.OnPropertyChanged("Start");
                }
            }
        }

        public DateTime End
        {
            get
            {
                return this.end;
            }
            set
            {
                if (this.end != value)
                {
                    this.end = value;
                    this.OnPropertyChanged("End");
                }
            }
        }

        public string Subject
        {
            get
            {
                return this.subject;
            }
            set
            {
                if (this.subject != value)
                {
                    this.subject = value;
                    this.OnPropertyChanged("Subject");
                }
            }
        }

        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                if (this.description != value)
                {
                    this.description = value;
                    this.OnPropertyChanged("Description");
                }
            }
        }

        public string Location
        {
            get
            {
                return this.location;
            }
            set
            {
                if (this.location != value)
                {
                    this.location = value;
                    this.OnPropertyChanged("Location");
                }
            }
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}
