#r "Newtonsoft.Json"
#load "maximolookup.csx"

using System;
using System.Net;
using Newtonsoft.Json;

public static async Task<object> Run(HttpRequestMessage req, TraceWriter log)
{
    log.Info($"Webhook was triggered!");

    string jsonContent = await req.Content.ReadAsStringAsync();
    dynamic data = JsonConvert.DeserializeObject(jsonContent);

    StatusDictionary lookupresult = null;
    Lookup lookupdata = LookupFactory.Create();
    
    switch(((string)data.source).ToLower())
    {
    case "electrixcode":
        lookupresult = lookupdata.StatusLookup.FirstOrDefault(item => item.ElectrixStatusCode == (string)data.code);
        break;
    case "maximocode":
        lookupresult = lookupdata.StatusLookup.FirstOrDefault(item => item.MaximoStatusCode == (string)data.code);
        break;
    case "crmcode":
        lookupresult = lookupdata.StatusLookup.FirstOrDefault(item => item.CRMStatusCode == (string)data.code);
        break;
    case "crmvalue":
        lookupresult = lookupdata.StatusLookup.FirstOrDefault(item => item.CRMStatusValue == (int)data.code);
        break;
    }

    return req.CreateResponse<object>(HttpStatusCode.OK, (object)lookupresult);
}
