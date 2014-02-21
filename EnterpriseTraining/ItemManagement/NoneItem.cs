using System.ComponentModel;

namespace EnterpriseTraining.ItemManagement
{
    public class NoneItem : IItem
    {
        private const string DisplayedText = "<None>";

        public event PropertyChangedEventHandler PropertyChanged;

        public override string ToString()
        {
            return DisplayedText;
        }
    }
}
