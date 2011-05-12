using System;
using Interfaces;

namespace Logic
{
    [Serializable]
    public class Request : IRequest
    {
        public Request(ISearchCriteria criteria) : this(criteria, 50)
        {
        }

        public Request(ISearchCriteria criteria, int depth)
        {
            Identifier = Environment.MachineName + Peer.Self.Name + DateTime.UtcNow;
            SearchCriteria = criteria;
            Requester = Peer.Self;
            Depth = depth;
        }

        #region Implementation of IRequest

        public string Identifier { get; private set; }

        public int Depth
        {
            get; private set;
        }

        public ISearchCriteria SearchCriteria
        {
            get; private set;
        }

        public IPeer Requester
        {
            get; private set;
        }

        public int DecrementDepth()
        {
            return Depth--;
        }

        #endregion

        public override int GetHashCode()
        {
            return Identifier.GetHashCode();
        }

        public override bool Equals(object other)
        {
            if(other is IRequest)
            {
                IRequest otherRequest = other as IRequest;
                if (Identifier.Equals(otherRequest.Identifier))
                    return true;
            }
            return false;
        }

        public bool Equals(IRequest otherRequest)
        {
            if (Identifier.Equals(otherRequest.Identifier))
                return true;
            return false;
        }
    }
}