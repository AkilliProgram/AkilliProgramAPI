using System;

namespace AkilliProgramApi.Controllers
{
    internal class sqlConnection
    {
        private Func<string> getConnection;

        public sqlConnection(Func<string> getConnection)
        {
            this.getConnection = getConnection;
        }
    }
}