using Newtonsoft.Json;
using RestSharp;
using System.Net;
using System.Text.Json.Nodes;

namespace HT_AT
{
    public class Tests
    {
        protected RestRequest restRequest;
        protected RestClient restClient;
        protected RestResponse restResponse;
 

        [SetUp]
        public async Task Setup()
        {
            restClient = new RestClient(@"https://jsonplaceholder.typicode.com/");
            restRequest = new RestRequest("users",Method.Get);
            restResponse = await restClient.ExecuteAsync(restRequest);
        }


        [Test]
        public void Test1()
        {
            Assert.True(restResponse.StatusCode==HttpStatusCode.OK);
        }

        [Test]
        public void Test2()
        {
            Assert.True(restResponse.ContentType == "application/json");
        }

        [Test]
        public void Test3()
        {
            var jsonobject = JsonConvert.DeserializeObject<List<Object>>(restResponse.Content);
            Assert.True(jsonobject.Count == 10);
        }

    }
}