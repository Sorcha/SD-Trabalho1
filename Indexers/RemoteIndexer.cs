using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interfaces;

namespace Indexers
{
    public class RemoteIndexer : MarshalByRefObject, IIndexer
    {
        public Uri SearchFor(ISearchCriteria criteria, int count)
        {
            throw new NotImplementedException();
        }

       
    }
}
