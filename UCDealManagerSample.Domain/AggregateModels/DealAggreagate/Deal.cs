using System;
using UCDealManagerSample.Domain.SeedWork;

namespace UCDealManagerSample.Domain.Deals
{
    public class Deal : Entity, IAggregateRoot
    {
        public DealID Id { get; private set; }

        private string _fakeProperty { get; set; }

        private Deal()
        {
            Id = new DealID(Guid.NewGuid());
        }

        private Deal(string fakeProperty)
        {
            Id = new DealID(Guid.NewGuid());

            _fakeProperty = fakeProperty;

        }

        public static Deal Create(string fakeProperty)
        {

            return new Deal(fakeProperty);
        }
    }
}
