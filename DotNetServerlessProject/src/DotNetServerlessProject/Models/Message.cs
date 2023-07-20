using Amazon.DynamoDBv2.DataModel;

namespace Store.Model
{
    [DynamoDBTable("MyStorageTable")]
    public class Message {

        [DynamoDBHashKey]
        public Guid myID { get; set; } = Guid.Empty;

        [DynamoDBProperty]
        public string message { get; set; } = string.Empty;
        [DynamoDBProperty]
        public string otherStuff { get; set; } = string.Empty;
        

    }
}