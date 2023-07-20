using Microsoft.AspNetCore.Mvc;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Store.Model;
using Store.Access;

namespace DotNetServerlessProject.Controllers;

[Route("/api")]
public class ValuesController : ControllerBase
{
    private static MessageRepository messageRepository = new MessageRepository(new DynamoDBContext(new AmazonDynamoDBClient()));
    // GET api/values
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/values
    [HttpPost]
    public void Post([FromBody]string value)
    {
    }

    // PUT api/values/5
    [HttpPut]
    public async Task<Guid> Put([FromBody]Message message)
    {
        return await messageRepository.CreateAsync(message);
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}