#r "Newtonsoft.Json"
#load "Utilities.csx"

using System;
using System.Net;
using Newtonsoft.Json;

public static async Task<object> Run(HttpRequestMessage req, TraceWriter log)
{
    log.Info($"Webhook was triggered!");

    string jsonContent = await req.Content.ReadAsStringAsync();
    dynamic data = JsonConvert.DeserializeObject(jsonContent);
    
    data.createddate = Utilities.ConvertToDateTime((string)data.createddate);
	data.accepteddate = Utilities.ConvertToDateTime((string)data.accepteddate);
	data.scheduleddate = Utilities.ConvertToDateTime((string)data.scheduleddate);
	data.etatime = Utilities.ConvertToDateTime((string)data.etatime);
	data.crewassigneddate = Utilities.ConvertToDateTime((string)data.crewassigneddate);
	data.onroutedate = Utilities.ConvertToDateTime((string)data.onroutedate);
	data.onsitedate = Utilities.ConvertToDateTime((string)data.onsitedate);
	data.offsitedate = Utilities.ConvertToDateTime((string)data.offsitedate);
	data.releasedate = Utilities.ConvertToDateTime((string)data.releasedate);
	data.supplylossdate = Utilities.ConvertToDateTime((string)data.supplylossdate);
	data.supplyrestoreddate = Utilities.ConvertToDateTime((string)data.supplyrestoreddate);
	data.etatargettime = Utilities.ConvertToDateTime((string)data.etatargettime);

    return req.CreateResponse<object>(HttpStatusCode.OK, (object)data);
}
