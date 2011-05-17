using System;
using System.Runtime.Remoting.Lifetime;

namespace Logic
{
    public class SearchEngineSponsor : ISponsor
    {
        #region Implementation of ISponsor

        public TimeSpan Renewal(ILease lease)
        {
            return new TimeSpan(0, 1, 0, 0);
        }

        #endregion
    }
}