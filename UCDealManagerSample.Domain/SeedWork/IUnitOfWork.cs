﻿using System.Threading;
using System.Threading.Tasks;

namespace UCDealManagerSample.Domain.SeedWork
{
    public interface IUnitOfWork
    {
        Task<int> CommitAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}