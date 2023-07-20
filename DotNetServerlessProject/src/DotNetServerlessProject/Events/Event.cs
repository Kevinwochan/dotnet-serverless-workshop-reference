
using Newtonsoft.Json;
using Amazon.EventBridge.Model;
using Store.Model;

namespace Producer.Data
{
  public class Event
  {

    public PutEventsRequest eventBuilder(Message message){
      return new PutEventsRequest
      {
        Entries = 
        {
          new PutEventsRequestEntry
          {
                Source = "my.source",
                EventBusName = "default",
                DetailType = "sampleEvent",
                Time = DateTime.Now,
                Detail = JsonConvert.SerializeObject(message)
          }
        }
      };
    }
  }
}