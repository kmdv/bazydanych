namespace EnterpriseTraining.ObjectManagement
{
    public interface IItemSaver
    {
        void SaveNew(IItem listItem);

        void SaveExisting(IItem listItem);
    }
}
