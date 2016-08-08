#r "Newtonsoft.Json"

using System;
using System.Net;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Xml;

const string SOAP_REQUEST =
@"<soapenv:Envelope xmlns:soapenv='http://schemas.xmlsoap.org/soap/envelope/' xmlns:opt='http://www.clicksoftware.com/OptionalParameters' xmlns:clic='http://www.clicksoftware.com'><soapenv:Header><opt:OptionalParameters/></soapenv:Header><soapenv:Body>{0}</soapenv:Body></soapenv:Envelope>";
const string SOAP_BODY = @"<ProcessTask><Task><CallID>{0}</CallID><DueDate>{1}</DueDate><Customer>{2}</Customer><OpenDate>{3}</OpenDate><TaskType>{4}</TaskType><ContactName>{5}</ContactName><ContactPhoneNumber>{6}</ContactPhoneNumber><Street>{7}</Street><City>{8}</City><State>{9}</State><ExternalRefID>{10}</ExternalRefID><Suburb>{11}</Suburb><District>Pool</District><Region>Incoming SR</Region><SubRequest>{12}</SubRequest><AddressNotes>{13}</AddressNotes><GasFaultDetectionReference>{14}</GasFaultDetectionReference><AccessGuardDog>{15}</AccessGuardDog><AccessLockedGate>{16}</AccessLockedGate><AccessGasMeterInside>{17}</AccessGasMeterInside><AccessPhoneBeforeEntry>{18}</AccessPhoneBeforeEntry><OtherHazards>{19}</OtherHazards><EmergencyServicesInvolved>{20}</EmergencyServicesInvolved><BuildingEvacuated>{21}</BuildingEvacuated><CustomersExtendedDescription>{22}</CustomersExtendedDescription><SROwnerReference>{23}</SROwnerReference><ReleaseDate>{24}</ReleaseDate><AccountName>{25}</AccountName><Questions>{26}</Questions><Answers>{27}</Answers></Task><ReturnAssignment>{28}</ReturnAssignment></ProcessTask>";

public static async Task<object> Run(HttpRequestMessage req, TraceWriter log)
{
    log.Info($"Webhook was triggered!");

    string jsonContent = await req.Content.ReadAsStringAsync();
    dynamic data = JsonConvert.DeserializeObject(jsonContent);
    
    string soapbody = string.Format(SOAP_BODY,
                                    data.callid,
                                    Convert.ToDateTime(data.opendate).AddHours(1).ToString("yyy-MM-ddTHH:mm:ss"),
                                    data.customer,
                                    Convert.ToDateTime(data.opendate).ToString("yyy-MM-ddTHH:mm:ss"),
                                    data.tasktype,
                                    data.contactname,
                                    data.contactphonenumber,
                                    data.street,
                                    data.city,
                                    data.state,
                                    data.externalrefid,
                                    data.suburb,
                                    data.subrequest,
                                    data.addressnotes,
                                    data.gasfaultdetectionreference,
                                    (Convert.ToBoolean(data.accessguarddog)?"true":"false"),
                                    (Convert.ToBoolean(data.accesslockedgate)?"true":"false"),
                                    (Convert.ToBoolean(data.accessgasmeterinside)?"true":"false"),
                                    (Convert.ToBoolean(data.accessphonebeforeentry)?"true":"false"),
                                    data.otherhazards,
                                    (Convert.ToBoolean(data.emergencyservicesinvolved)?"Y":"N"),
                                    (Convert.ToBoolean(data.buildingevacuated)?"Y":"N"),
                                    data.customerextendeddescription,
                                    data.srownerreference,
                                    data.releasedate,
                                    data.accountname,
                                    data.questions,
                                    data.answers,
                                    "true");
    string soaprequest = string.Format(SOAP_REQUEST,soapbody);

    var response = req.CreateResponse(HttpStatusCode.OK, soaprequest);
    response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/xml");
    
    return response;

}
