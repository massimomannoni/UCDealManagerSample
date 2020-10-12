using System;
using MediatR;

namespace UCDealManagerSample.Domain.SeedWork
{
    public interface IDomainEvent : INotification
    {
        DateTime OccurredOn { get; }
    }
}
