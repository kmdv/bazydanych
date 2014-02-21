namespace EnterpriseTraining.ItemManagement
{
    public interface IItemSaver
    {
        void SaveNew(IItem item);

        void SaveExisting(IItem item);
    }
}
