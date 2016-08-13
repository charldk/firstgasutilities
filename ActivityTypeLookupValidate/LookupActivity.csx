#r "Newtonsoft.Json"

using System;
using System.Net;
using Newtonsoft.Json;

public class Lookup
    {
        public List<NameValuePair> FaultActivityType { get; set; }
    }
    
        public class NameValuePair
    {
        public string Code { get; set; }
        public string Value { get; set; }
    }
    
    public class FaultActivityTypeResult
    {
        public bool IsValid {get; set; }
        public NameValuePair FaultActivityType { get; set; }
    }

    static string[] validactivitytypes = {"Additional Information","Administration","Call-Inbound", "Call-Outbound", "Email - Inbound", "Email - Outbound"};
    static string[] validstatuscodes = {"Open","Accepted","Onroute"};
    
    public static class Utilities
    {
        public static bool ValidateNoteActivityType(string activitytype, string statuscode = "")
        {
            List<string> validactivitytypelist = new List<string>();
            List<string> validstatuscodelist = new List<string>();
            validactivitytypelist.AddRange(validactivitytypes);
            validstatuscodelist.AddRange(validstatuscodes);
            return (validactivitytypelist.Contains(activitytype) && validstatuscodelist.Contains(statuscode));
        }
        
        public static NameValuePair LookupActivityType (string value)
        {
            Create();
            var activitytype = lookupdata.FaultActivityType.FirstOrDefault(item => item.Value == value);
            
            return (activitytype == null)? new NameValuePair() : activitytype;
        }

        static Lookup lookupdata;
        
        private static Lookup Create()
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