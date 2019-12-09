using System.Collections.Generic;
using System.Linq;
using backend.Models;
using MongoDB.Driver;

namespace backend.Services {
    public class PostService {
        private readonly IMongoCollection<Post> _posts;

        public PostService (IPoststoreDatabaseSettings settings) {
            var client = new MongoClient ("mongodb+srv://development:8veDmKagfUMNBvCn@cluster0-5mfoa.mongodb.net/test?retryWrites=true&w=majority");
            var database = client.GetDatabase ("posts");

            _posts = database.GetCollection<Post> (settings.PostsCollectionName);
        }

        public List<Post> Get () =>
            _posts.Find (post => true).ToList ();

        public Post Get (string id) =>
            _posts.Find<Post> (post => post.Id == id).FirstOrDefault ();

        public Post Create (Post post) {
            _posts.InsertOne (post);
            return post;
        }

        public void Update (string id, Post postIn) =>
            _posts.ReplaceOne (post => post.Id == id, postIn);

        public void Remove (Post postIn) =>
            _posts.DeleteOne (post => post.Id == postIn.Id);

        public void Remove (string id) =>
            _posts.DeleteOne (post => post.Id == id);
    }
}