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
    for (int x =0; x < data.Count; x++)
    {
        result.Add(new Appliance(){applianceid = data[x].new_applianceid, estquantity = data[x].new_estquantity, name = data[x].new_name, icp = data[x].new_icp, comments= data[x].new_comments});
    }

    return req.CreateResponse(HttpStatusCode.OK, (object)result);
}
