#r "Newtonsoft.Json"
#load "JsonValidatorResult.csx"

using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Schema;

public static async Task<object> Run(HttpRequestMessage req, TraceWriter log)
{
    log.Info($"C# HTTP trigger function processed a request. RequestUri={req.RequestUri}");

        // Get request body
    string jsonContent = await req.Content.ReadAsStringAsync();
    dynamic data = JsonConvert.DeserializeObject(jsonContent);
    

    // Set name to query string or body data
    var jsonschema = data.jsonschema.ToString();
    var jsonobject = data.jsonobject.ToString();
    
    IList<String> validationerrors;
    JSchema schema = JSchema.Parse(jsonschema);
    JObject myobject = JObject.Parse(jsonobject);
    bool isvalid = myobject.IsValid(schema, out validationerrors);

    JsonValidatorResult validationresult = new JsonValidatorResult();
    validationresult.IsValid = isvalid;
    validationresult.Messages = validationerrors;
   
   return  req.CreateResponse(HttpStatusCode.OK, validationresult);
}
