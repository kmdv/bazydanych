namespace EnterpriseTraining.ObjectManagement
{
    public class NullItemEditor : IItemEditor
    {
        public ItemEditResult Edit(IItem item)
        {
            return ItemEditResult.Cancelled;
        }
    }
}
