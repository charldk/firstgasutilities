#r "Newtonsoft.Json"

using System;
using System.Net;
using Newtonsoft.Json;

public class ElectrixB2BMessage
{
public String contactfirstname { get; set; }
public String contactlastname { get; set; }
public String contactphonenumber { get; set; }
public String siteaddress { get; set; }
public String siteaddresssuburb { get; set; }
public String siteaddresscity { get; set; }
public String siteaddressnotes { get; set; }
public String accessguarddog { get; set; }
public String accesslockedgate { get; set; }
public String accessgasmeterinside { get; set; }
public String accessphonebeforeentry { get; set; }
public String buildingevacuated { get; set; }
public String emergencyservicesinvolved { get; set; }
public String otherhazards { get; set; }
public String casenumber { get; set; }
public String accountname { get; set; }
public String srowner { get; set; }
public String customerreferenceid { get; set; }
public String srtype { get; set; }
public String srsubtype { get; set; }
public String inprogressreason { get; set; }
public String gasfaultdetection { get; set; }
public String statusdescription { get; set; }
public String sropeneddate { get; set; }
public String activityid { get; set; }
public String activitynumber { get; set; }
public String comment { get; set; }
public String description { get; set; }
public String due { get; set; }
public String owner { get; set; }
public String planned { get; set; }
public String status { get; set; }
public String type { get; set; }
public String accepteddate { get; set; }
public String scheduleddate { get; set; }
public String estimatedarrivaldate { get; set; }
public String offsitedate { get; set; }
public String onroutedate { get; set; }
public String onsitedate { get; set; }
public String releasedate { get; set; }
public String supplylossdate { get; set; }
public String supplyrestoreddate { get; set; }
public String gasfailuremode { get; set; }
public String faultfound { get; set; }
public String latereason { get; set; }
public String meterreading { get; set; }
public String meterserialno { get; set; }
public String metertypereference { get; set; }
public String networksupplylosstocustomer { get; set; }
public String latlong { get; set; }
public String networksupplylosstype { get; set; }
public String serviceregion { get; set; }
public String customersaffected { get; set; }
public String crewassigneddate { get; set; }
public String followup { get; set; }
public String manualupdatereason { get; set; }
public String asfoundleakclassification { get; set; }
public String asfoundleakcheckmethod { get; set; }
public String asfoundleakreadingpercentlel { get; set; }
public String asfoundleakreadingpercentgas { get; set; }
public String asleftleakclassification { get; set; }
public String asleftleakcheckmethod { get; set; }
public String asleftleakreadingpercentlel { get; set; }
public String asleftleakreadingpercentgas { get; set; }
public String confirmedescape { get; set; }
public String confirmedpoornetworkpressure { get; set; }
public String gasassetmaterial { get; set; }
public String gasassetsubtype { get; set; }
public String gasassettype { get; set; }
public String gasleftonoff { get; set; }
public String gassystempressure { get; set; }
public String meterpressureasfound { get; set; }
public String meterpressureasleft { get; set; }
public String regulatortype { get; set; }
public String regulatorserialno { get; set; }
public String relightdetails { get; set; }
}

public static class Utilities
{
    private static TimeZoneInfo timezone = TimeZoneInfo.FindSystemTimeZoneById("New Zealand Standard Time");
    
    public static string GetDateTimeUTC(string inputstring)
    {
        DateTime inputdatetime;
        DateTime.TryParse(inputstring, out inputdatetime);
        if (inputdatetime == null || inputdatetime == DateTime.MinValue)
        {
            return null;
        }
        else
        {
            DateTime utcdatetime = TimeZoneInfo.ConvertTimeToUtc(
                                    DateTime.SpecifyKind(
                                    inputdatetime, DateTimeKind.Unspecified), timezone); 
            return utcdatetime.ToString("yyyy-MM-ddTHH:mm:ssZ");

        }
    }
}