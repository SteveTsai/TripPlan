using Google.Cloud.Datastore.V1;
using static Google.Cloud.Datastore.V1.Key.Types;
using static Google.Cloud.Datastore.V1.PropertyOrder.Types;

namespace GoogleCloudSamples
{
    public class QuickStart
    {
        public static void Main(string[] args)
        {
            // Your Google Cloud Platform project ID
            string projectId = "vrrobot-174303";

            // Instantiates a client
            DatastoreDb db = DatastoreDb.Create(projectId);

            // The kind for the new entity
            string kind = "Kind2";
            // The keyName/ID for the new entity
            string keyName = "5644004762845184";

            KeyFactory keyFactory = db.CreateKeyFactory(kind);
            // The Cloud Datastore key for the new entity
            Key key = keyFactory.CreateKey(keyName);

            var task = new Entity
            {
                Key = key,
                ["description"] = "Buy milk"
            };
            using (DatastoreTransaction transaction = db.BeginTransaction())
            {
                // Saves the task
                transaction.Upsert(task);
                transaction.Commit();

                Console.WriteLine($"Saved {task.Key.Path[0].Name}: {(string)task["description"]}");
            }

            // Send the request and retrieve the response
            Query query = new Query("Kind");
            DatastoreQueryResults tasks = db.RunQuery(query);

            foreach (var ent in tasks.Entities)
            {
                Console.WriteLine($"key = {ent.Key}, property = {ent.Properties}");
            }

            // 2nd namespace
            DatastoreDb try1db = DatastoreDb.Create(projectId, "FireStore.Try.1");

            // Print the messages created in the last 5 minutes, most recent first
            DateTime cutoff = DateTime.UtcNow.AddMinutes(-5);
            Query query2 = new Query("message")
            {
                Filter = Filter.GreaterThanOrEqual("created", cutoff),
                Order = { { "created", Direction.Descending } }
            };
            foreach (Entity entity in try1db.RunQueryLazily(query2))
            {
                DateTime created = (DateTime)entity["created"];
                string text = (string)entity["text"];
                Console.WriteLine($"{created:yyyy-MM-dd'T'HH:mm:ss}: {text}");
            }

            Key key2 = try1db.CreateKeyFactory("Kind").CreateKey(5644004762845184);

            Entity ent2 = try1db.Lookup(key2);
            Console.WriteLine($"key = {ent2.Key}, property = {ent2.Properties}");
        }
    }
}