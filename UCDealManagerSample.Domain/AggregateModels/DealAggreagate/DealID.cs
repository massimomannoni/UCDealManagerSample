using System;
using UCDealManagerSample.Domain.SeedWork;

namespace UCDealManagerSample.Domain.Deals
{
    public class DealID : TypedIdValueBase
    {
        public DealID(Guid value) : base(value) { }
    }
}
