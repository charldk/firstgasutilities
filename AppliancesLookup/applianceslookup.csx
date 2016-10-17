#r "Newtonsoft.Json"

using System;
using System.Net;
using Newtonsoft.Json;

 public class Lookup
    {
        public List<NameValuePair> Appliances { get; set; }
    
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
'Appliances':
[
  {
    'Code': 'Bayonet',
    'Value': 100000007
  },
  {
    'Code': 'BB',
    'Value': 100000008
  },
  {
    'Code': 'BBQ',
    'Value': 100000022
  },
  {
    'Code': 'Central Heating',
    'Value': 100000003
  },
  {
    'Code': 'Commercial Boiler',
    'Value': 100000009
  },
  {
    'Code': 'Commercial Cook Top',
    'Value': 100000010
  },
  {
    'Code': 'Commercial Dryer',
    'Value': 100000023
  },
  {
    'Code': 'Commercial Fryer',
    'Value': 100000011
  },
  {
    'Code': 'Commercial Furnace',
    'Value': 100000012
  },
  {
    'Code': 'Commercial G22',
    'Value': 100000024
  },
  {
    'Code': 'Commercial Heating',
    'Value': 100000013
  },
  {
    'Code': 'Commercial Hot Water Unit',
    'Value': 100000014
  },
  {
    'Code': 'Commercial Kiln',
    'Value': 100000015
  },
  {
    'Code': 'Commercial manifolded hot water supply',
    'Value': 100000016
  },
  {
    'Code': 'Commercial Outdoor Heating',
    'Value': 100000017
  },
  {
    'Code': 'Commercial Oven',
    'Value': 100000020
  },
  {
    'Code': 'Commercial Radiant Heater',
    'Value': 100000018
  },
  {
    'Code': 'Commercial Spray Booth',
    'Value': 100000019
  },
  {
    'Code': 'Commercial Wok Bench',
    'Value': 100000025
  },
  {
    'Code': 'Cooking',
    'Value': 100000005
  },
  {
    'Code': 'Flame Effect',
    'Value': 100000026
  },
  {
    'Code': 'Hot Water Continuous',
    'Value': 100000001
  },
  {
    'Code': 'Hot Water Storage',
    'Value': 100000000
  },
  {
    'Code': 'New Connection',
    'Value': 100000027
  },
  {
    'Code': 'Other Appliances',
    'Value': 100000028
  },
  {
    'Code': 'Pool/Spa heating',
    'Value': 100000004
  },
  {
    'Code': 'Space Heating',
    'Value': 100000002
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