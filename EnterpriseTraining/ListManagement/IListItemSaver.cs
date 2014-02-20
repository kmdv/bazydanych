namespace EnterpriseTraining.ListManagement
{
    public interface IListItemSaver
    {
        void SaveNew(IListItem listItem);

        void SaveExisting(IListItem listItem);
    }
}
