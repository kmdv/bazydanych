using EnterpriseTraining.Entities;

namespace EnterpriseTraining.EntityManagement
{
    public sealed class TrainingStringizer : IEntityStringizer<Training>
    {
        public string Stringize(Training training)
        {
            return training.Name;
        }
    }
}
