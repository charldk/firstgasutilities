#r "Newtonsoft.Json"

using System;
using System.Net;
using Newtonsoft.Json;

 public class Lookup
    {
        public List<NameValuePair> ActivityPriority { get; set; }
        public List<NameValuePair> GasAssetMaterial { get; set; }
        public List<NameValuePair> GasAssetSubType { get; set; }
        public List<NameValuePair> GasAssetType { get; set; }
        public List<NameValuePair> GasFailureMode { get; set; }
        public List<NameValuePair> GasFaultDetection { get; set; }
        public List<NameValuePair> GasSystemPressure { get; set; }
        public List<NameValuePair> IsFault { get; set; }
        public List<NameValuePair> ServiceRegion { get; set; }
        public List<NameValuePair> ServiceRequestSubType { get; set; }
        public List<NameValuePair> ServiceRequestType { get; set; }
        public List<NameValuePair> LeakCheckMethod { get; set; }
        public List<NameValuePair> NetworkSupplyLossType { get; set; }



    
    }

    public static class LookupFactory
    {
        public static object Lookup(string input)
        {
            dynamic data = JsonConvert.DeserializeObject(input);
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
            var networksupplylosstype = lookupdata.NetworkSupplyLossType.FirstOrDefault(item => item.Code == (string)data.networksupplylosstype);
            
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
            data.networksupplylosstype = (networksupplylosstype == null)? null : networksupplylosstype.Value;
            
            return (object)data;
        }
        
        public static object ReverseLookup (string input)
        {
            dynamic data = JsonConvert.DeserializeObject(input);
            Lookup lookupdata = LookupFactory.Create();
    
            var activitypriority = lookupdata.ActivityPriority.FirstOrDefault(item => item.Value == (string)data.activitypriority);
            var gasassetmaterial = lookupdata.GasAssetMaterial.FirstOrDefault(item => item.Value == (string)data.gasassetmaterial);
            var gasassetsubtype = lookupdata.GasAssetSubType.FirstOrDefault(item => item.Value == (string)data.gasassetsubtype);
            var gasassettype = lookupdata.GasAssetType.FirstOrDefault(item => item.Value == (string)data.gasassettype);
            var gasfailuremode = lookupdata.GasFailureMode.FirstOrDefault(item => item.Value == (string)data.gasfailuremode);
            var gasfaultdetection = lookupdata.GasFaultDetection.FirstOrDefault(item => item.Value == (string)data.gasfaultdetection);
            var gassystempressure = lookupdata.GasSystemPressure.FirstOrDefault(item => item.Value == (string)data.gassystempressure);
            var isfault = lookupdata.IsFault.FirstOrDefault(item => item.Value == (string)data.isfault);
            var serviceregion = lookupdata.ServiceRegion.FirstOrDefault(item => item.Value == (string)data.serviceregion);
            var servicerequestsubtype = lookupdata.ServiceRequestSubType.FirstOrDefault(item => item.Value == (string)data.srsubtype);
            var servicerequesttype = lookupdata.ServiceRequestType.FirstOrDefault(item => item.Value == (string)data.srtype);
            var asfoundleakcheckmethod = lookupdata.LeakCheckMethod.FirstOrDefault(item => item.Value == (string)data.asfoundleakcheckmethod);
            var asleftleakcheckmethod = lookupdata.LeakCheckMethod.FirstOrDefault(item => item.Value == (string)data.asleftleakcheckmethod);
            var networksupplylosstype = lookupdata.NetworkSupplyLossType.FirstOrDefault(item => item.Value == (string)data.networksupplylosstype);
            
            data.activitypriority = (activitypriority == null)? null : activitypriority.Code;
            data.gasassetmaterial = (gasassetmaterial == null)? null : gasassetmaterial.Code;
            data.gasassetsubtype = (gasassetsubtype == null)? null : gasassetsubtype.Code;
            data.gasassettype = (gasassettype == null)? null : gasassettype.Code;
            data.gasfailuremode = (gasfailuremode == null)? null : gasfailuremode.Code;
            data.gasfaultdetection = (gasfaultdetection == null)? null : gasfaultdetection.Code;
            data.gassystempressure = (gassystempressure == null)? null : gassystempressure.Code;
            data.isfault = (isfault == null)? null : isfault.Code;
            data.serviceregion = (serviceregion == null)? null : serviceregion.Code;
            data.srsubtype = (servicerequestsubtype == null)? null : servicerequestsubtype.Code;
            data.srtype = (servicerequesttype == null)? null : servicerequesttype.Code;
            data.asfoundleakcheckmethod = (asfoundleakcheckmethod == null)? null : asfoundleakcheckmethod.Code;
            data.asleftleakcheckmethod = (asleftleakcheckmethod == null)? null : asleftleakcheckmethod.Code;
            data.networksupplylosstype = (networksupplylosstype == null)? null : networksupplylosstype.Code;
            
            return (object)data;
        }
        static Lookup lookupdata;
        public static Lookup Create()
        {
            if (lookupdata == null)
            {
                lookupdata = JsonConvert.DeserializeObject<Lookup>(lookupjson);
            }
            return lookupdata;
        }
        #region Lookup Json
        public const string lookupjson = @"{
'ActivityPriority':
[
  {
    'Code': '1 - Critical',
    'Value': 100000000
  },
  {
    'Code': '2 - High',
    'Value': 100000001
  },
  {
    'Code': '3 - Normal',
    'Value': 100000002
  },
  {
    'Code': '4 - Extended',
    'Value': 100000003
  },
  {
    'Code': '5 - Appointment',
    'Value': 100000004
  }
],
'GasAssetMaterial':
[
  {
    'Code': 'Cast Iron',
    'Value': 100000000
  },
  {
    'Code': 'Nylon',
    'Value': 100000001
  },
  {
    'Code': 'PE',
    'Value': 100000002
  },
  {
    'Code': 'Stainless Steel',
    'Value': 100000003
  },
  {
    'Code': 'Other',
    'Value': 100000004
  },
  {
    'Code': 'Steel',
    'Value': 100000005
  }
],
'GasAssetSubType':
[
  {
    'Code': 'DRS Other',
    'Value': 100000000
  },
  {
    'Code': 'DRS Pipework & Fittings',
    'Value': 100000001
  },
  {
    'Code': 'DRS Regulator',
    'Value': 100000002
  },
  {
    'Code': 'DRS Relief/Opso',
    'Value': 100000003
  },
  {
    'Code': 'Mains Fitting',
    'Value': 100000004
  },
  {
    'Code': 'Mains Pipe',
    'Value': 100000005
  },
  {
    'Code': 'Mains Valve',
    'Value': 100000006
  },
  {
    'Code': 'Other',
    'Value': 100000007
  },
  {
    'Code': 'Riser Valve',
    'Value': 100000008
  },
  {
    'Code': 'Riser Crimp',
    'Value': 100000009
  },
  {
    'Code': 'Riser Pipe',
    'Value': 100000010
  },
  {
    'Code': 'Service Pipe',
    'Value': 100000011
  },
  {
    'Code': 'Service Valve',
    'Value': 100000012
  },
  {
    'Code': 'Street Regulator',
    'Value': 100000013
  },
  {
    'Code': 'MLV',
    'Value': 100000014
  },
  {
    'Code': 'Pipeline',
    'Value': 100000015
  },
  {
    'Code': 'Easement',
    'Value': 100000016
  },
  {
    'Code': 'Customer Installation',
    'Value': 100000017
  },
  {
    'Code': 'GMS - Contact',
    'Value': 100000018
  },
  {
    'Code': 'GMS - Nova',
    'Value': 100000019
  },
  {
    'Code': 'GMS - NGCM',
    'Value': 100000020
  },
  {
      'Code': 'Service Fitting',
      'Value': '100000021'
  }
],
'GasAssetType':
[
  {
    'Code': 'Network Distribution',
    'Value': 100000002
  },
  {
    'Code': 'LPG Network',
    'Value': 100000001
  },
  {
    'Code': 'Transmission',
    'Value': 100000004
  },
  {
    'Code': 'Non FG Asset',
    'Value': 100000003
  }
],
'GasFailureMode':
[
  {
    'Code': 'Construction Defect',
    'Value': 100000000
  },
  {
    'Code': 'Corrosion',
    'Value': 100000001
  },
  {
    'Code': 'Equipment Failure',
    'Value': 100000002
  },
  {
    'Code': 'TPD - Other Contractor',
    'Value': 100000003
  },
  {
    'Code': 'TPD - FG Contractor',
    'Value': 100000004
  },
  {
    'Code': 'Unknown',
    'Value': 100000005
  },
  {
    'Code': 'Water Ingress',
    'Value': 100000006
  },
  {
    'Code': 'N/A',
    'Value': 100000007
  }
],
'GasFaultDetection':
[
  {
    'Code': 'Customer/General Public',
    'Value': 100000000
  },
  {
    'Code': 'Emergency Services',
    'Value': 100000001
  },
  {
    'Code': 'Leakage Survey',
    'Value': 100000002
  },
  {
    'Code': 'On Site (FG Contractor)',
    'Value': 100000003
  },
  {
    'Code': 'Retailer',
    'Value': 100000004
  },
  {
    'Code': 'Third Party Contractor',
    'Value': 100000005
  }
],
'GasSystemPressure':
[
  {
    'Code': 'LP - Up to 7kPa',
    'Value': 100000000
  },
  {
    'Code': 'MP1 - 7kPa up to 110kPa',
    'Value': 100000001
  },
  {
    'Code': 'MP2 - 110kPa up to 210kPa',
    'Value': 100000002
  },
  {
    'Code': 'MP4 - 210kPa up to 420kPa',
    'Value': 100000003
  },
  {
    'Code': 'MP7 - 420kPa up to 700kPa',
    'Value': 100000004
  },
  {
    'Code': 'IP10 - 700kPa up to 1000kPa',
    'Value': 100000005
  },
  {
    'Code': 'IP20 - 1000kPa up to 2000kPa',
    'Value': 100000006
  },
  {
    'Code': 'HP - Over 2000kPa',
    'Value': 100000007
  },
  {
    'Code': 'N/A',
    'Value': 100000008
  }
],
'IsFault':
[
  {
    'Code': 'Yes',
    'Value': 100000000
  },
  {
    'Code': 'No',
    'Value': 100000001
  }
],
'ServiceRegion':
[
  {
    'Code': 'Central Rotorua Gas Distribution',
    'Value': 100000000
  },
  {
    'Code': 'Central Rotorua Gas Meters',
    'Value': 100000001
  },
  {
    'Code': 'Central Rotorua Gas Transmission',
    'Value': 100000002
  },
  {
    'Code': 'Central Taupo Gas Distribution',
    'Value': 100000003
  },
  {
    'Code': 'Central Taupo Gas Meters',
    'Value': 100000004
  },
  {
    'Code': 'Central Taupo Gas Transmission',
    'Value': 100000005
  },
  {
    'Code': 'Gisborne Gas Distribution',
    'Value': 100000006
  },
  {
    'Code': 'Gisborne Gas Meters',
    'Value': 100000007
  },
  {
    'Code': 'Gisborne Gas Transmission',
    'Value': 100000008
  },
  {
    'Code': 'Hawkes Bay Gas Meters',
    'Value': 100000009
  },
  {
    'Code': 'Kapiti Gas Distribution',
    'Value': 100000010
  },
  {
    'Code': 'Kapiti Gas Meters',
    'Value': 100000011
  },
  {
    'Code': 'Kapiti Gas Transmission',
    'Value': 100000012
  },
  {
    'Code': 'New Plymouth Gas Meters',
    'Value': 100000013
  },
  {
    'Code': 'South Island Meters',
    'Value': 100000014
  },
  {
    'Code': 'Tauranga Gas Distribution',
    'Value': 100000015
  },
  {
    'Code': 'Tauranga Gas Meters',
    'Value': 100000016
  },
  {
    'Code': 'Tauranga Gas Transmission',
    'Value': 100000017
  },
  {
    'Code': 'Tauranga LPG Retic',
    'Value': 100000018
  },
  {
    'Code': 'Waikato Gas Distribution',
    'Value': 100000019
  },
  {
    'Code': 'Waikato Gas Meters',
    'Value': 100000020
  },
  {
    'Code': 'Waikato Gas Transmission',
    'Value': 100000021
  },
  {
    'Code': 'Wellington Gas Distribution',
    'Value': 100000022
  },
  {
    'Code': 'Wellington Gas Meters',
    'Value': 100000023
  },
  {
    'Code': 'Whakatane Gas Distribution',
    'Value': 100000024
  },
  {
    'Code': 'Whakatane Gas Meters',
    'Value': 100000025
  },
  {
    'Code': 'Whakatane Gas Transmission',
    'Value': 100000026
  },
  {
    'Code': 'Whangarei Gas Distribution',
    'Value': 100000027
  }
],
'ServiceRequestSubType':
[
  {
    'Code': 'New',
    'Value': 100000000
  },
  {
    'Code': 'Customer Contacted',
    'Value': 100000001
  },
  {
    'Code': 'Design and Price',
    'Value': 100000002
  },
  {
    'Code': 'Quote Sent',
    'Value': 100000003
  },
  {
    'Code': 'Quote Expired',
    'Value': 100000004
  },
  {
    'Code': 'Quote Rejected',
    'Value': 100000005
  },
  {
    'Code': 'Quote Accepted',
    'Value': 100000006
  },
  {
    'Code': 'Payment Received',
    'Value': 100000007
  },
  {
    'Code': 'On Hold',
    'Value': 100000008
  },
  {
    'Code': 'Documents Received',
    'Value': 100000009
  },
  {
    'Code': 'Site Visit',
    'Value': 100000010
  },
  {
    'Code': 'Create ICP',
    'Value': 100000011
  },
  {
    'Code': 'Retailer Confirmed',
    'Value': 100000012
  },
  {
    'Code': 'Work Prepared',
    'Value': 100000013
  },
  {
    'Code': 'Date Confirmed',
    'Value': 100000014
  },
  {
    'Code': 'Connection Complete',
    'Value': 100000015
  },
  {
    'Code': 'Install Meter',
    'Value': 100000016
  },
  {
    'Code': 'Update ICP',
    'Value': 100000017
  },
  {
    'Code': 'Reinstatement Complete',
    'Value': 100000018
  },
  {
    'Code': 'GIS Updated',
    'Value': 100000019
  },
  {
    'Code': 'All Work Complete',
    'Value': 100000020
  },
  {
    'Code': 'Closed',
    'Value': 100000021
  },
  {
    'Code': 'No Gas',
    'Value': 100000022
  },
  {
    'Code': 'Poor Gas Pressure',
    'Value': 100000025
  },
  {
    'Code': 'Smell of Gas - Inside',
    'Value': 100000026
  },
  {
    'Code': 'Smell of Gas - Outside',
    'Value': 100000029
  },
  {
    'Code': 'Damaged Asset - Gas Leak',
    'Value': 100000030
  },
  {
    'Code': 'Damaged Asset - No Gas Leak',
    'Value': 100000031
  },
  {
    'Code': 'Faulty Meter',
    'Value': 100000032
  },
  {
    'Code': 'Emergency Isolate',
    'Value': 100000027
  },
  {
    'Code': 'Check for Safety',
    'Value': 100000023
  },
  {
    'Code': 'Relight',
    'Value': 100000024
  },
  {
      'Code': 'Urgent',
      'Value': '100000028'
  }
],
'ServiceRequestType':
[
  {
    'Code': 'New Connection',
    'Value': 100000000
  },
  {
    'Code': 'Reconnection',
    'Value': 100000001
  },
  {
    'Code': 'Disconnection',
    'Value': 100000002
  },
  {
    'Code': 'Relocation',
    'Value': 100000003
  },
  {
    'Code': 'Upgrade',
    'Value': 100000004
  },
  {
    'Code': 'Faults - Gas',
    'Value': 100000005
  },
  {
      'Code': 'Pipe Locations',
      'Value': 100000006
  }
],
'LeakCheckMethod':
[
  {
    'Code': 'CGI',
    'Value': 100000000
  },
  {
    'Code': 'FIM',
    'Value': 100000001
  },
  {
    'Code': 'Soap',
    'Value': 100000002
  }
],
'NetworkSupplyLossType':
[
  {
    'Code': 'Unplanned',
    'Value': 100000002
  },
  {
    'Code': 'Temporary Disconnection',
    'Value': 100000003
  },
  {
    'Code': 'Permanent Isolation',
    'Value': 100000000
  },
  {
    'Code': 'Planned',
    'Value': 100000001
  },
]
}";
        #endregion
    }


    public class NameValuePair
    {
        public string Code { get; set; }
        public string Value { get; set; }
    }