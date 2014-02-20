using System.ComponentModel;

using EnterpriseTraining.ObjectManagement;
using EnterpriseTraining.Entities;

namespace EnterpriseTraining.EntityManagement
{
    public class EntityItem<T> : IItem
        where T : class
    {
        private readonly IEntityStringizer<T> _entityStringizer;

        private T _entity = null;

        public event PropertyChangedEventHandler PropertyChanged;

        public EntityItem(IEntityStringizer<T> entityStringizer)
        {
            _entityStringizer = entityStringizer;
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
            return _entityStringizer.Stringize(_entity);
        }
    }
}
