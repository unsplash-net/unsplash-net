namespace Unsplash.Api.Collections
{
    public static class CollectionsApiUrls
    {
        public static string List() => "/collections";

        public static string GetCollection(string collectionId) => $"/collections/{collectionId}";

        public static string GetCollectionPhotos(string collectionId) => $"/collections/{collectionId}/photos";

        public static string GetRelatedCollections(string collectionId) => $"/collections/{collectionId}/related";
    }
}
