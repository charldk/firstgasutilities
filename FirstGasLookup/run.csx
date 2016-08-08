#r "Newtonsoft.Json"
#load "firstgaslookup.csx"

using System;
using System.Net;
using Newtonsoft.Json;

public static async Task<object> Run(HttpRequestMessage req, TraceWriter log)
{
    log.Info($"Webhook was triggered!");
    
    string jsonContent = await req.Content.ReadAsStringAsync();
    dynamic data = JsonConvert.DeserializeObject(jsonContent);
    /*
    Lookup lookupdata = LookupFactory.Create();
    
    var activitypriority = lookupdata.ActivityPriority.FirstOrDefault(item => item.Code == (string)data.activitypriority);
    var gasassetmaterial = lookupdata.GasAssetMaterial.FirstOrDefault(item => item.Code == (string)data.gasassetmaterial);
    var gasassetsubtype = lookupdata.GasAssetSubType.FirstOrDefault(item => item.Code == (string)data.gasassetsubtype);
    var gasassettype = lookupdata.GasAssetType.FirstOrDefault(item => item.Code == (string)data.gasassettype);
    var gasfailuremode = lookupdata.GasFailureMode.FirstOrDefault(item => item.Code == (string)data.gasfailuremode);
    var gasfaultdetection = lookupdata.GasFaultDetection.FirstOrDefault(item => item.Code == (string)data.gasfaultdetection);
    var gassystempressure = lookupdata.GasSystemPressure.FirstOrDefault(item => item.Code == (string)data.gassystempressure);
    var isfault = lookupdata.IsFault.FirstOrDefault(item => item.Code == (string)data.isfault);
    var serviceregion = lookupdata.ServiceRegion.FirstOrDefault(item => item.Code == (string)data.serviceregion);
    var servicerequestsubtype = lookupdata.ServiceRequestSubType.FirstOrDefault(item => item.Code == (string)data.srsubtype);
    var servicerequesttype = lookupdata.ServiceRequestType.FirstOrDefault(item => item.Code == (string)data.srtype);
    var asfoundleakcheckmethod = lookupdata.LeakCheckMethod.FirstOrDefault(item => item.Code == (string)data.asfoundleakcheckmethod);
    var asleftleakcheckmethod = lookupdata.LeakCheckMethod.FirstOrDefault(item => item.Code == (string)data.asleftleakcheckmethod);
    
    data.activitypriority = (activitypriority == null)? null : activitypriority.Value;
    data.gasassetmaterial = (gasassetmaterial == null)? null : gasassetmaterial.Value;
    data.gasassetsubtype = (gasassetsubtype == null)? null : gasassetsubtype.Value;
    data.gasassettype = (gasassettype == null)? null : gasassettype.Value;
    data.gasfailuremode = (gasfailuremode == null)? null : gasfailuremode.Value;
    data.gasfaultdetection = (gasfaultdetection == null)? null : gasfaultdetection.Value;
    data.gassystempressure = (gassystempressure == null)? null : gassystempressure.Value;
    data.isfault = (isfault == null)? null : isfault.Value;
    data.serviceregion = (serviceregion == null)? null : serviceregion.Value;
    data.srsubtype = (servicerequestsubtype == null)? null : servicerequestsubtype.Value;
    data.srtype = (servicerequesttype == null)? null : servicerequesttype.Value;
    data.asfoundleakcheckmethod = (asfoundleakcheckmethod == null)? null : asfoundleakcheckmethod.Value;
    data.asleftleakcheckmethod = (asleftleakcheckmethod == null)? null : asleftleakcheckmethod.Value;
    */
    
    object result = null;
    
    if ((string)data.lookupmethod == "reverse")
    {
        result = LookupFactory.ReverseLookup(jsonContent);
    }
    else
    {
        result = LookupFactory.Lookup(jsonContent);
    }
    
    return req.CreateResponse<object>(HttpStatusCode.OK, (object)result);
}
