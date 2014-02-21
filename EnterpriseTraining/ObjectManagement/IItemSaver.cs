namespace EnterpriseTraining.ObjectManagement
{
    public interface IItemSaver
    {
        void SaveNew(IItem item);

        void SaveExisting(IItem item);
    }
}
