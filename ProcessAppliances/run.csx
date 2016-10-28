#r "Newtonsoft.Json"
#load "Appliances.csx"

using System;
using System.Net;
using Newtonsoft.Json;

public static async Task<object> Run(HttpRequestMessage req, TraceWriter log)
{
    log.Info($"Webhook was triggered!");
    
    List<Appliance> result = new List<Appliance>();

    string jsonContent = await req.Content.ReadAsStringAsync();
    dynamic data = JsonConvert.DeserializeObject(jsonContent);
    for (int x =0; x < data.appliances.Count; x++)
    {
        result.Add(new Appliance(){applianceid = data.appliances[x].new_applianceid, estquantity = data.appliances[x].new_estquantity, name = data.appliances[x].new_name, icp = data.appliances[x].new_icp, applianceitem=data.appliances[x].new_appliancetype, comments= data.appliances[x].new_comments});
    }

    return req.CreateResponse(HttpStatusCode.OK, (object)result);
}
