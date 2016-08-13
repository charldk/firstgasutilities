#r "Newtonsoft.Json"
#load "LookupActivity.csx"

using System;
using System.Net;
using Newtonsoft.Json;

public static async Task<object> Run(HttpRequestMessage req, TraceWriter log)
{
    log.Info($"Webhook was triggered!");

    string jsonContent = await req.Content.ReadAsStringAsync();
    dynamic data = JsonConvert.DeserializeObject(jsonContent);

    var result = new FaultActivityTypeResult();
    result.FaultActivityType = Utilities.LookupActivityType((string)data.activitytype);
    result.IsValid = Utilities.ValidateNoteActivityType(result.FaultActivityType.Code, (string)data.statuscode);
   
    return req.CreateResponse<object>(HttpStatusCode.OK, (object)result);
}
