﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Unsplash.Models;

namespace Unsplash.Api.Collections
{
    public interface ICollectionsApi
    {
        Task<IEnumerable<CollectionBasic>> ListAsync(ListCollectionsParams parameters = null);
        Task<CollectionBasic> GetCollectionAsync(string collectionId);
        Task<IEnumerable<PhotoBasic>> GetCollectionPhotosAsync(string collectionId, GetCollectionPhotosParams parameters = null);
        Task<IEnumerable<CollectionBasic>> GetRelatedCollectionsAsync(string collectionId);
    }
}