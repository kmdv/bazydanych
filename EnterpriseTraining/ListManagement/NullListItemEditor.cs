namespace EnterpriseTraining.ListManagement
{
    public class NullListItemEditor : IListItemEditor
    {
        public ListItemEditResult Edit(IListItem listItem)
        {
            return ListItemEditResult.Cancelled;
        }
    }
}
