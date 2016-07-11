#r "Newtonsoft.Json"

using System;
using System.Net;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Xml;

const string SOAP_REQUEST =
@"<soapenv:Envelope xmlns:soapenv='http://schemas.xmlsoap.org/soap/envelope/' xmlns:opt='http://www.clicksoftware.com/OptionalParameters' xmlns:clic='http://www.clicksoftware.com'><soapenv:Header><opt:OptionalParameters/></soapenv:Header><soapenv:Body>{0}</soapenv:Body></soapenv:Envelope>";
const string SOAP_BODY = @"<ProcessTask><Task><CallID>{0}</CallID><Number>0</Number><OpenDate>{1}</OpenDate><EarlyStart>{2}</EarlyStart><LateStart>{3}</LateStart><DueDate>{4}</DueDate><Region>Incoming SR</Region><District>Pool</District><Street>230 PONSONBY ROAD</Street><City>AUCKLAND</City><State/><CountryID>NEW ZEALAND</CountryID><TaskType>Faults - Gas</TaskType><Duration>3600</Duration><Postcode/></Task><TaskRequestedProperties><Item>CallID</Item><Item>Number</Item></TaskRequestedProperties><ReturnSchedulingError>true</ReturnSchedulingError></ProcessTask>";

public static async Task<object> Run(HttpRequestMessage req, TraceWriter log)
{
    log.Info($"Webhook was triggered!");

    string jsonContent = await req.Content.ReadAsStringAsync();
    dynamic data = JsonConvert.DeserializeObject(jsonContent);
    
    string soapbody = string.Format(SOAP_BODY,data.callid,
                                    DateTime.Now.ToString("yyyy-MM-ddThh:00:00"), 
                                    DateTime.Now.AddHours(12).ToString("yyyy-MM-ddThh:00:00"), 
                                    DateTime.Now.AddHours(13).ToString("yyyy-MM-ddThh:00:00"), 
                                    DateTime.Now.AddDays(2).ToString("yyyy-MM-ddThh:00:00"));
    string soaprequest = string.Format(SOAP_REQUEST,soapbody);

    var response = req.CreateResponse(HttpStatusCode.OK, soaprequest);
    response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/xml");
    
    return response;

}
