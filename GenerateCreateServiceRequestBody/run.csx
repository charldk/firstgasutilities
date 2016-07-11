#r "Newtonsoft.Json"

using System;
using System.Net;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Xml;

const string SOAP_REQUEST =
@"<soapenv:Envelope xmlns:soapenv='http://schemas.xmlsoap.org/soap/envelope/'><soapenv:Header/><soapenv:Body>{0}</soapenv:Body></soapenv:Envelope>";
const string SOAP_BODY = @"<ServiceRequest xmlns='http://servicebus.electrix.co.nz/schema/FirstGasServiceRequest' CreatedDate='{0}'><SRNO>{1}</SRNO><SERVICEREGION>{2}</SERVICEREGION><SERVICE>{3}</SERVICE><SRTYPE>{4}</SRTYPE><SRSUBTYPE>{5}</SRSUBTYPE><CREATED>{6}</CREATED><SRADDRNOTE>{7}</SRADDRNOTE><DESCRIPTION>{8}</DESCRIPTION></ServiceRequest>";

public static async Task<object> Run(HttpRequestMessage req, TraceWriter log)
{
    log.Info($"Webhook was triggered!");

    string jsonContent = await req.Content.ReadAsStringAsync();
    dynamic data = JsonConvert.DeserializeObject(jsonContent);
    
    DateTime datecreated = Convert.ToDateTime(data.createddate);
    
    string soapbody = string.Format(SOAP_BODY,
    datecreated.ToString("O"),
    data.casenumber,
    data.serviceregion,
    data.service,
    data.servicetype,
    data.servicesubtype,
    datecreated.ToString("dd/MM/yyyy"),
    data.address,
    data.description);
    string soaprequest = string.Format(SOAP_REQUEST,soapbody);

    var response = req.CreateResponse(HttpStatusCode.OK, soaprequest);
    response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/xml");
    
    return response;

}
