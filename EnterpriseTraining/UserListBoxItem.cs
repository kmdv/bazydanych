using System.ComponentModel;

using EnterpriseTraining.Entities;

namespace EnterpriseTraining
{
    public sealed class UserListBoxItem : INotifyPropertyChanged
    {
        private const string FullNameFormat = "{0} {1}";

        private User _user = new User();

        public event PropertyChangedEventHandler PropertyChanged;

        public User User
        {
            get
            {
                return _user;
            }
            set
            {
                _user = value;

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("User"));
                }
            }
        }

        public override string ToString()
        {
            if (User.FirstName != null)
            {
                if (User.LastName != null)
                {
                    return string.Format(FullNameFormat, User.FirstName, User.LastName);
                }
            }

            if (User.LastName != null)
            {
                return User.LastName;
            }

            return string.Empty;
        }
    }
}
