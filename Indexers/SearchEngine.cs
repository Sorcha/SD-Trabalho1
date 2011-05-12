using System;
using Interfaces;

namespace Logic
{
    public class SearchEngine : MarshalByRefObject, ISearchEngine
    {
        #region Implementation of ISearchEngine

        public void StartSearching(ISearchCriteria criteria)
        {
            IRequest request = new Request(criteria);

            StartSearching(request);
        }

        public void StartSearching(IRequest request)
        {
            request.DecrementDepth();
            Uri localPath = Peer.Self.LocalIndexer.SearchFor(request.SearchCriteria);
            if (request.Depth != 0 && localPath == null)
            {
                new RemoteIndexer().SearchFor(request);
            }
            else
            {
                request.Requester.ResponseCallback(request, localPath);
            }
        }

        #endregion

    }
}