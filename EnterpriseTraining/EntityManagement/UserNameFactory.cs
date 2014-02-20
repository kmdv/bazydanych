﻿using EnterpriseTraining.Entities;
using EnterpriseTraining.EntityManagement;

namespace EnterpriseTraining.EntityManagement
{
    public sealed class UserNameFactory : IEntityNameFactory<User>
    {
        private const string FullNameFormat = "{0} {1}";

        public string Create(User user)
        {
            if (user.FirstName != null)
            {
                if (user.LastName != null)
                {
                    return string.Format(FullNameFormat, user.FirstName, user.LastName);
                }

                return user.FirstName;
            }

            if (user.LastName != null)
            {
                return user.LastName;
            }

            return string.Empty;
        }
    }
}
