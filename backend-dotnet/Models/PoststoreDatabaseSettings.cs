namespace backend.Models {
    public class PoststoreDatabaseSettings : IPoststoreDatabaseSettings {

        public string PostsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IPoststoreDatabaseSettings {

        string PostsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}