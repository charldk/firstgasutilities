#r "Newtonsoft.Json"

using System;
using System.Net;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Text;

public static async Task<object> Run(HttpRequestMessage req, TraceWriter log)
{
    log.Info($"Webhook was triggered!");

    string jsonContent = await req.Content.ReadAsStringAsync();
    dynamic data = JsonConvert.DeserializeObject(jsonContent);
    StringBuilder csv = new StringBuilder();
    csv.AppendLine(@"physicaladdresstown,physicaladdressnumber,icpstatuscode,physicaladdressunit,responsibleretailercode,gasregistrydataid,icpidentifier,connectionstatuscode,physicaladdressstreet,originalcommissioningeventdate,modifiedon,networkpressure,gasgatecode,createdon,physicaladdressregion,physicaladdresspropertyname,physicaladdresspostcode,physicaladdresssuburb,compositeaddress,versionnumber");
    for (int x = 0; x < data.Count; x++)
    {
        csv.AppendLine(String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19}",
                        data[x].new_physicaladdresstown,
                        data[x].new_physicaladdressnumber,
                        data[x].new_icpstatuscode,
                        data[x].new_physicaladdressunit,
                        data[x].new_responsibleretailercode,
                        data[x].new_gasregistrydataid,
                        data[x].new_icpidentifier,
                        data[x].new_connectionstatuscode,
                        data[x].new_physicaladdressstreet,
                        data[x].new_originalcommissioningeventdate,
                        data[x].modifiedon,
                        data[x].new_networkpressure,
                        data[x].new_gasgatecode,
                        data[x].createdon,
                        data[x].new_physicaladdressregion,
                        data[x].new_physicaladdresspropertyname,
                        data[x].new_physicaladdresspostcode,
                        data[x].new_physicaladdresssuburb,
                        data[x].new_compositeaddress,
                        data[x].versionnumber));
    }
    
    var bytes = Encoding.UTF8.GetBytes(csv.ToString());
    var result = Convert.ToBase64String(bytes);
    var response = req.CreateResponse(HttpStatusCode.OK, result);
    return response;
}
