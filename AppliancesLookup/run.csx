#r "Newtonsoft.Json"
#load "applianceslookup.csx"
using System;
using System.Net;
using Newtonsoft.Json;

public static async Task<object> Run(HttpRequestMessage req, TraceWriter log)
{
    log.Info($"Webhook was triggered!");

    string jsonContent = await req.Content.ReadAsStringAsync();
    dynamic data = JsonConvert.DeserializeObject(jsonContent);

    Lookup lookupdata = LookupFactory.Create();

    var result = lookupdata.Appliances.FirstOrDefault(item => item.Code == (string)data.appliancename);
    data.appliancevalue = (result == null)? null : result.Value;

    return req.CreateResponse(HttpStatusCode.OK, (object)data);
}
