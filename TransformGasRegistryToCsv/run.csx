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
    for (int x = 0; x < data.ICPList.Count; x++)
    {
        csv.AppendLine(String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19}",
                        data.ICPList[x].new_physicaladdresstown,
                        data.ICPList[x].new_physicaladdressnumber,
                        data.ICPList[x].new_icpstatuscode,
                        data.ICPList[x].new_physicaladdressunit,
                        data.ICPList[x].new_responsibleretailercode,
                        data.ICPList[x].new_gasregistrydataid,
                        data.ICPList[x].new_icpidentifier,
                        data.ICPList[x].new_connectionstatuscode,
                        data.ICPList[x].new_physicaladdressstreet,
                        data.ICPList[x].new_originalcommissioningeventdate,
                        data.ICPList[x].modifiedon,
                        data.ICPList[x].new_networkpressure,
                        data.ICPList[x].new_gasgatecode,
                        data.ICPList[x].createdon,
                        data.ICPList[x].new_physicaladdressregion,
                        data.ICPList[x].new_physicaladdresspropertyname,
                        data.ICPList[x].new_physicaladdresspostcode,
                        data.ICPList[x].new_physicaladdresssuburb,
                        data.ICPList[x].new_compositeaddress,
                        data.ICPList[x].versionnumber));
    }
    
    var bytes = Encoding.UTF8.GetBytes(csv.ToString());
    var result = Convert.ToBase64String(bytes);
    var response = req.CreateResponse(HttpStatusCode.OK, result);
    return response;
}
