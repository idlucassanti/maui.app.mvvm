using System.ComponentModel;

namespace MVVM.Models
{
    public class Pearson : INotifyPropertyChanged
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; OnPropertyChanged(nameof(Id)); }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; OnPropertyChanged(nameof(Email)); }
        }

        private string _password;
        public string Password
        { 
            get { return _password; }
            set { _password = value; OnPropertyChanged(nameof(Password)); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string prop)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
