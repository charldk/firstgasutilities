#r "Newtonsoft.Json"

using System;
using System.Net;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Xml;

public static async Task<object> Run(HttpRequestMessage req, TraceWriter log)
{
    log.Info($"Webhook was triggered!");

    string jsonContent = await req.Content.ReadAsStringAsync();
    dynamic data = JsonConvert.DeserializeObject(jsonContent);
    
    string soapbody = $"<ProcessTask><Task><CallID>{data.mainactivityid}</CallID><Notes><Note><CreatedFrom/><CreatedAt>{data.activitycreated.ToString("yyyy-MM-ddTHH:mm:ss")}</CreatedAt><ActivityTypeReference>{data.activitytype}</ActivityTypeReference><AssignedTo>{data.assignedto}</AssignedTo><NoteDescription>{data.activitynotes}</NoteDescription><NoteComment>{data.activitycomments}</NoteComment><NoteRef>{data.activityid}</NoteRef></Note></Notes></Task><ReturnAssignment>false</ReturnAssignment></ProcessTask>";
    string soaprequest = $"<soapenv:Envelope xmlns:soapenv='http://schemas.xmlsoap.org/soap/envelope/' xmlns:opt='http://www.clicksoftware.com/OptionalParameters' xmlns:clic='http://www.clicksoftware.com'><soapenv:Header><opt:OptionalParameters/></soapenv:Header><soapenv:Body>{soapbody}</soapenv:Body></soapenv:Envelope>";

    var response = req.CreateResponse(HttpStatusCode.OK, soaprequest);
    response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/xml");
    
    return response;

}
