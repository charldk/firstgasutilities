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



    
    }

    public static class LookupFactory
    {
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
  }
],
'GasAssetType':
[
  {
    'Code': 'Network Distribution',
    'Value': 100000000
  },
  {
    'Code': 'LPG Network',
    'Value': 100000001
  },
  {
    'Code': 'Transmission',
    'Value': 100000002
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
    'Code': 'Equipement Failure',
    'Value': 100000002
  },
  {
    'Code': 'TPD - Other Contractor',
    'Value': 100000003
  },
  {
    'Code': 'TPD - First Gas Contractor',
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
    '100000000': 100000001,
    'Customer/General Public': 'Emergency Services'
  },
  {
    '100000000': 100000002,
    'Customer/General Public': 'Leakage Survey'
  },
  {
    '100000000': 100000003,
    'Customer/General Public': 'Onsite (FG Contractor)'
  },
  {
    '100000000': 100000004,
    'Customer/General Public': 'Retailer'
  },
  {
    '100000000': 100000005,
    'Customer/General Public': 'Third Party Contractor'
  }
],
'GasSystemPressure':
[
  {
    'Code': 'LPG- Up to 7kPa',
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
    'Code': 'MP3 - 210kPa up to 420kPa',
    'Value': 100000003
  },
  {
    'Code': 'MP4 - 420kPa up to 700kPa',
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
    'Code': 'HP - over 2000kPa',
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
    'Code': 'Faults - No Gas',
    'Value': 100000022
  },
  {
    'Code': 'Faults - Poor Gas Pressure',
    'Value': 100000023
  },
  {
    'Code': 'Faults - Smell of Gas - Inside',
    'Value': 100000024
  },
  {
    'Code': 'Faults - Smell of Gas - Outside',
    'Value': 100000025
  },
  {
    'Code': 'Faults - Damaged Asset - Gas Leak',
    'Value': 100000026
  },
  {
    'Code': 'Faults - Damaged Asset - No Gas Leak',
    'Value': 100000027
  },
  {
    'Code': 'Faults - Faulty Meter',
    'Value': 100000028
  },
  {
    'Code': 'Faults - Emergency Isolate',
    'Value': 100000029
  },
  {
    'Code': 'Faults - Check for Safety',
    'Value': 100000030
  },
  {
    'Code': 'Faults - Relight',
    'Value': 100000031
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
  }
]
}";
        #endregion
    }


    public class NameValuePair
    {
        public string Code { get; set; }
        public string Value { get; set; }
    }