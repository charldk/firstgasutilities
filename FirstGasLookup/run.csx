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

    Lookup lookupdata = LookupFactory.Create();
    
    var activitypriority = lookupdata.ActivityPriority.FirstOrDefault(item => item.Code == (string)data.new_activitypriority);
    var gasassetmaterial = lookupdata.GasAssetMaterial.FirstOrDefault(item => item.Code == (string)data.new_gasassetmaterial);
    var gasassetsubtype = lookupdata.GasAssetSubType.FirstOrDefault(item => item.Code == (string)data.new_gasassetsubtype);
    var gasassettype = lookupdata.GasAssetType.FirstOrDefault(item => item.Code == (string)data.new_gasassettype);
    var gasfailuremode = lookupdata.GasFailureMode.FirstOrDefault(item => item.Code == (string)data.new_gasfailuremode);
    var gasfaultdetection = lookupdata.GasFaultDetection.FirstOrDefault(item => item.Code == (string)data.new_gasfaultdetection);
    var gassystempressure = lookupdata.GasSystemPressure.FirstOrDefault(item => item.Code == (string)data.new_gassystempressure);
    var isfault = lookupdata.IsFault.FirstOrDefault(item => item.Code == (string)data.new_isfault);
    var serviceregion = lookupdata.ServiceRegion.FirstOrDefault(item => item.Code == (string)data.new_serviceregion);
    var servicerequestsubtype = lookupdata.ServiceRequestSubType.FirstOrDefault(item => item.Code == (string)data.new_srsubtype);
    var servicerequesttype = lookupdata.ServiceRequestType.FirstOrDefault(item => item.Code == (string)data.new_srtype);
    
    data.new_activitypriority = (activitypriority == null)? null : activitypriority.Value;
    data.new_gasassetmaterial = (gasassetmaterial == null)? null : gasassetmaterial.Value;
    data.new_gasassetsubtype = (gasassetsubtype == null)? null : gasassetsubtype.Value;
    data.new_gasassettype = (gasassettype == null)? null : gasassettype.Value;
    data.new_gasfailuremode = (gasfailuremode == null)? null : gasfailuremode.Value;
    data.new_gasfaultdetection = (gasfaultdetection == null)? null : gasfaultdetection.Value;
    data.new_gassystempressure = (gassystempressure == null)? null : gassystempressure.Value;
    data.new_isfault = (isfault == null)? null : isfault.Value;
    data.new_serviceregion = (serviceregion == null)? null : serviceregion.Value;
    data.new_srsubtype = (servicerequestsubtype == null)? null : servicerequestsubtype.Value;
    data.new_srtype = (servicerequesttype == null)? null : servicerequesttype.Value;
    
    
    return req.CreateResponse<object>(HttpStatusCode.OK, (object)data);
}
