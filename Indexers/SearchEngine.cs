using System;
using Interfaces;
using Interfaces.Model;
using Logic.Model;

namespace Logic
{
    public class SearchEngine : MarshalByRefObject, ISearchEngine
    {
        private readonly IIndexer<ISearchCriteria> _localIndexer;

        public SearchEngine(MusicDatabase database, ReceiveResponse callback)
        {
            _localIndexer = new LocalIndexer(database);
            Callback = callback;
            Database = database;
        }

        #region Implementation of ISearchEngine

        public void StartSearching(ISearchCriteria criteria)
        {
            IRequest request = new Request(criteria);

            StartSearching(request);
        }

        public void StartSearching(IRequest request)
        {
            request.DecrementDepth();
            Uri localPath = _localIndexer.SearchFor(request.SearchCriteria);
            if (request.Depth != 0 && localPath == null)
            {
                new RemoteIndexer().SearchFor(request);
            }
            else
            {
                Callback(request, localPath);
            }
        }
        
        public ReceiveResponse Callback { get; private set; }

        public IMusicDatabase Database { get; private set; }

        #endregion

    }
}