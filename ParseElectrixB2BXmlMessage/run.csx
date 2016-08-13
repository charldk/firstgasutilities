#r "Newtonsoft.Json"
#load "electrixb2bmessage.csx"

using System;
using System.Net;
using Newtonsoft.Json;

public static async Task<object> Run(HttpRequestMessage req, TraceWriter log)
{
    log.Info($"Webhook was triggered!");

    string jsonContent = await req.Content.ReadAsStringAsync();
    dynamic input = JsonConvert.DeserializeObject(jsonContent);
    System.Xml.XmlDocument electrixb2bmsgxml = new System.Xml.XmlDocument();
    electrixb2bmsgxml.LoadXml((string)input.msg);
    string electrixb2bmsg = JsonConvert.SerializeXmlNode(electrixb2bmsgxml.DocumentElement);
    dynamic data = JsonConvert.DeserializeObject(electrixb2bmsg);
    ElectrixB2BMessage result = new ElectrixB2BMessage();

    var createddate = Utilities.GetDateTimeUTC((string)data.B2BElectrixRequestType.Status.CreatedDate);
	var accepteddate = Utilities.GetDateTimeUTC((string)data.B2BElectrixRequestType.Activity.AcceptedDate);
	var scheduleddate = Utilities.GetDateTimeUTC((string)data.B2BElectrixRequestType.Activity.ScheduledDate);
	var estimatedarrivaldate = Utilities.GetDateTimeUTC((string)data.B2BElectrixRequestType.Activity.EstimatedArrivalDate);
	var crewassigneddate = Utilities.GetDateTimeUTC((string)data.B2BElectrixRequestType.Activity.AssignedDate);
	var onroutedate = Utilities.GetDateTimeUTC((string)data.B2BElectrixRequestType.Activity.OnRouteDate);
	var onsitedate = Utilities.GetDateTimeUTC((string)data.B2BElectrixRequestType.Activity.OnSiteDate);
	var offsitedate = Utilities.GetDateTimeUTC((string)data.B2BElectrixRequestType.Activity.OffSiteDate);
	var releasedate = Utilities.GetDateTimeUTC((string)data.B2BElectrixRequestType.Activity.ReleaseDate);
	var supplylossdate = Utilities.GetDateTimeUTC((string)data.B2BElectrixRequestType.Activity.SupplyLossDate);
	var supplyrestoreddate = Utilities.GetDateTimeUTC((string)data.B2BElectrixRequestType.Activity.SupplyRestoredDate);
	var due = Utilities.GetDateTimeUTC((string)data.B2BElectrixRequestType.Activity.due);

    result.contactfirstname = data.B2BElectrixRequestType.Contact.ContactFirstName;
    result.contactlastname = data.B2BElectrixRequestType.Contact.ContactSecondName;
    result.contactphonenumber = data.B2BElectrixRequestType.Contact.ContactPhone;
    result.siteaddress = data.B2BElectrixRequestType.Location.AddressStreet;
    result.siteaddresssuburb = data.B2BElectrixRequestType.Location.AddressSuburb;
    result.siteaddresscity = data.B2BElectrixRequestType.Location.AddressCity;
    result.siteaddressnotes = data.B2BElectrixRequestType.Location.AddressNotes;
    result.accessguarddog = data.B2BElectrixRequestType.Location.GuardDog;
    result.accesslockedgate = data.B2BElectrixRequestType.Location.LockedGate;
    result.accessgasmeterinside = data.B2BElectrixRequestType.Location.MeterInside;
    result.accessphonebeforeentry = data.B2BElectrixRequestType.Location.PhoneBeforeEntry;
    result.buildingevacuated = data.B2BElectrixRequestType.Location.BuildingEvacuated;
    result.emergencyservicesinvolved = data.B2BElectrixRequestType.Location.EmergencyServicesonSite;
    result.otherhazards = data.B2BElectrixRequestType.Location.OtherHazards;

    result.casenumber = data.B2BElectrixRequestType.ReferenceData.SRNumber;
    result.parentcasenumber = data.B2BElectrixRequestType.ReferenceData.RelatedSRNumber;
    result.accountname = data.B2BElectrixRequestType.ReferenceData.Account;
    result.srowner = data.B2BElectrixRequestType.ReferenceData.Owner;
    result.customerreferenceid = data.B2BElectrixRequestType.ReferenceData.CustomerRefNumber;


    result.srsubtype = data.B2BElectrixRequestType.Status.SubType;
    result.inprogressreason = data.B2BElectrixRequestType.Status.InProgressReason;
    result.gasfaultdetection = data.B2BElectrixRequestType.Status.GasFaultDetectedBy;
    result.statusdescription = data.B2BElectrixRequestType.Status.Description;
    result.sropeneddate = createddate;

	result.activityid = data.B2BElectrixRequestType.Activity.ActivityId;
	result.activitynumber = data.B2BElectrixRequestType.Activity.Number;
    result.comment = data.B2BElectrixRequestType.Activity.Comment;
    result.description = data.B2BElectrixRequestType.Activity.Description;
    result.due = due;
    result.owner = data.B2BElectrixRequestType.Activity.Owner;
    result.planned = data.B2BElectrixRequestType.Activity.Planned;
    result.status = data.B2BElectrixRequestType.Activity.Status;
    result.srtype = data.B2BElectrixRequestType.Activity.Type;
    result.accepteddate = accepteddate;
    result.scheduleddate = scheduleddate;
    result.estimatedarrivaldate = estimatedarrivaldate;
    result.offsitedate = offsitedate;
    result.onroutedate = onroutedate;
    result.onsitedate = onsitedate;
    result.releasedate = releasedate;
    result.supplylossdate = supplylossdate;
    result.supplyrestoreddate = supplyrestoreddate;
    result.gasfailuremode = data.B2BElectrixRequestType.Activity.FailureMode;
    result.faultfound = data.B2BElectrixRequestType.Activity.FaultFound;
    result.latereason = data.B2BElectrixRequestType.Activity.LateReason;
    result.meterreading = data.B2BElectrixRequestType.Activity.MeterReading;
    result.meterserialno = data.B2BElectrixRequestType.Activity.MeterSerialNo;
    result.metertypereference = data.B2BElectrixRequestType.Activity.MeterTypeReference;
    result.networksupplylosstocustomer = data.B2BElectrixRequestType.Activity.NetworkSupplyLossToCustomer;
    result.latlong = data.B2BElectrixRequestType.Activity.LatLong;
    result.networksupplylosstype = data.B2BElectrixRequestType.Activity.SupplyLoss;
    result.serviceregion = data.B2BElectrixRequestType.Activity.ServiceRegion;
    result.customersaffected = data.B2BElectrixRequestType.Activity.CustomersAffected;
    result.crewassigneddate = crewassigneddate;
    result.followup = data.B2BElectrixRequestType.Activity.FollowUp;
    result.manualupdatereason = data.B2BElectrixRequestType.Activity.ManualUpdateReason;
    result.asfoundleakclassification = data.B2BElectrixRequestType.GasActivityDetails.AsFoundLeakClassification;
    result.asfoundleakcheckmethod = data.B2BElectrixRequestType.GasActivityDetails.Asfoundleakcheckmethod;
    result.asfoundleakreadingpercentlel = data.B2BElectrixRequestType.GasActivityDetails.AsfoundleakreadingpercentLEL;
    result.asfoundleakreadingpercentgas = data.B2BElectrixRequestType.GasActivityDetails.AsfoundleakreadingpercentGas;
    result.asleftleakclassification = data.B2BElectrixRequestType.GasActivityDetails.AsLeftLeakClassification;
    result.asleftleakcheckmethod = data.B2BElectrixRequestType.GasActivityDetails.Asleftleakcheckmethod;
    result.asleftleakreadingpercentlel = data.B2BElectrixRequestType.GasActivityDetails.AsleftleakreadingpercentLEL;
    result.asleftleakreadingpercentgas = data.B2BElectrixRequestType.GasActivityDetails.AsleftleakreadingpercentGas;
    result.confirmedescape = data.B2BElectrixRequestType.GasActivityDetails.ConfirmedEscape;
    result.confirmedpoornetworkpressure = data.B2BElectrixRequestType.GasActivityDetails.ConfirmedPoorPressure;
    result.gasassetmaterial = data.B2BElectrixRequestType.GasActivityDetails.GasAssetMaterial;
    result.gasassetsubtype = data.B2BElectrixRequestType.GasActivityDetails.GasAssetSubType;
    result.gasassettype = data.B2BElectrixRequestType.GasActivityDetails.GasAssetType;
    result.gasleftonoff = data.B2BElectrixRequestType.GasActivityDetails.GasLeftOnOff;
    result.gassystempressure = data.B2BElectrixRequestType.GasActivityDetails.GasSystemPresssure;
    result.meterpressureasfound = data.B2BElectrixRequestType.GasActivityDetails.MeterPressureAsFound;
    result.meterpressureasleft = data.B2BElectrixRequestType.GasActivityDetails.MeterPressureAsLeft;
    result.regulatortype = data.B2BElectrixRequestType.GasActivityDetails.RegulatorType;
    result.regulatorserialno = data.B2BElectrixRequestType.GasActivityDetails.RegulatorSerialNo;
    result.relightdetails = data.B2BElectrixRequestType.GasActivityDetails.RelightDetails;

    return req.CreateResponse(HttpStatusCode.OK, new {result});
}
