namespace EnterpriseTraining.ObjectManagement
{
    public class NullItemEditor : IItemEditor
    {
        public ItemEditResult Edit(IItem listItem)
        {
            return ItemEditResult.Cancelled;
        }
    }
}
