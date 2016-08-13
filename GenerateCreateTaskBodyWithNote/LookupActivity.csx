#r "Newtonsoft.Json"

using System;
using System.Net;
using Newtonsoft.Json;

 public class Lookup
    {
        public List<NameValuePair> FaultActivityType { get; set; }
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
            'FaultActivityType':[
  {
    'Value': 100000000,
    'Code': 'Additional Information'
  },
  {
    'Value': 100000001,
    'Code': 'Administration'
  },
  {
    'Value': 100000002,
    'Code': 'Asset Database Update'
  },
  {
    'Value': 100000003,
    'Code': 'Assign Crew'
  },
  {
    'Value': 100000004,
    'Code': 'Call-Inbound'
  },
  {
    'Value': 100000005,
    'Code': 'Call-Outbound'
  },
  {
    'Value': 100000006,
    'Code': 'Email - Inbound'
  },
  {
    'Value': 100000007,
    'Code': 'Email - Outbound'
  },
  {
    'Value': 100000011,
    'Code': 'SR Information Update'
  },
  {
    'Value': 100000008,
    'Code': 'Follow Up'
  },
  {
    'Value': 100000009,
    'Code': 'GIS Update'
  },
  {
    'Value': 100000010,
    'Code': 'SAP Update'
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