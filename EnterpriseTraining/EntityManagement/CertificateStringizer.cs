using EnterpriseTraining.Entities;

namespace EnterpriseTraining.EntityManagement
{
    public sealed class CertificateStringizer : IEntityStringizer<Certificate>
    {
        public string Stringize(Certificate certificate)
        {
            return certificate.Name;
        }
    }
}
