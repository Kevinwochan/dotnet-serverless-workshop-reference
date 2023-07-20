using Amazon.DynamoDBv2.DataModel;
using Store.Model;

namespace Store.Access
{
    public class MessageRepository
    {
        private readonly IDynamoDBContext context;

        public MessageRepository(IDynamoDBContext context)
        {
            this.context = context;
        }
        public async Task<Guid> CreateAsync(Message message)
        {
            try
            {
                message.myID = Guid.NewGuid();
                await context.SaveAsync(message);
            }
            catch (Exception e)
            {
                return Guid.Empty;
            }
            return message.myID;
        }

        public async Task<Message?> GetByIdAsync(Guid id)
        {
            try
            {
                return await context.LoadAsync<Message>(id);
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }

}