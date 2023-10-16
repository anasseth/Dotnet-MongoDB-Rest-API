namespace Catalog.Settings
{
    public class MongoDBSettings
    {
        public string Host { get; init; }
        public string Port { get; init; }
        public string AtlasUsername { get; init; }
        public string AtlasPassword { get; init; }
        public string ConnectionString
        {
            get
            {
                return $"mongodb+srv://{AtlasUsername}:{AtlasPassword}@cluster0.stvqq.mongodb.net/?retryWrites=true&w=majority";
            }
        }
    }
}