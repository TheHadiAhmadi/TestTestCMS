﻿using FluentCMS.Entities;

namespace FluentCMS.Repositories;

public interface ISiteRepository : IGenericRepository<Site>
{
    Task<Site?> GetByUrl(string url, CancellationToken cancellationToken = default);
    Task<bool> CheckUrls(IList<string> urls, CancellationToken cancellationToken = default);
}