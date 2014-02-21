﻿using System;
using System.Data.SqlClient;

namespace EnterpriseTraining.Sql
{
    public interface ISession : IDisposable
    {
        SqlCommand CreateQuery(string queryText);

        SqlCommand CreateCommand(string commandText);

        void FlushChanges();
    }
}
