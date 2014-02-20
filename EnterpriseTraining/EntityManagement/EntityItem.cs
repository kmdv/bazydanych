using System.ComponentModel;

using EnterpriseTraining.ListManagement;
using EnterpriseTraining.Entities;

namespace EnterpriseTraining.EntityManagement
{
    public class EntityItem<T> : IListItem
        where T : class
    {
        private readonly IEntityNameFactory<T> _entityNameFactory;

        private T _entity = null;

        public event PropertyChangedEventHandler PropertyChanged;

        public EntityItem(IEntityNameFactory<T> entityNameFactory)
        {
            _entityNameFactory = entityNameFactory;
        }

        public T Entity
        {
            get
            {
                return _entity;
            }

            set
            {
                _entity = value;

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Entity"));
                }
            }
        }

        public override string ToString()
        {
            return _entityNameFactory.Create(_entity);
        }
    }
}
