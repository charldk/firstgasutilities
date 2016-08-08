#r "Newtonsoft.Json"

using System;
using System.Net;
using Newtonsoft.Json;

 public class Lookup
    {
        public List<StatusDictionary> StatusLookup { get; set; }
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
	'StatusLookup': [
  {
    'ElectrixStatusCode': 'Open',
    'MaximoStatusCode': 'NEW',
    'CRMStatusCode': 'New',
    'CRMStatusValue': 100000036
  },
  {
    'ElectrixStatusCode': 'In Progress',
    'MaximoStatusCode': 'INPRG',
    'CRMStatusCode': 'In Progress',
    'CRMStatusValue': 1
  },
  {
    'ElectrixStatusCode': 'NONE',
    'MaximoStatusCode': 'ONHOLD',
    'CRMStatusCode': 'On Hold',
    'CRMStatusValue': 2
  },
  {
    'ElectrixStatusCode': 'NONE',
    'MaximoStatusCode': 'NONE',
    'CRMStatusCode': 'Waiting for Details',
    'CRMStatusValue': 3
  },
  {
    'ElectrixStatusCode': 'NONE',
    'MaximoStatusCode': 'NONE',
    'CRMStatusCode': 'Researching',
    'CRMStatusValue': 4
  },
  {
    'ElectrixStatusCode': 'NONE',
    'MaximoStatusCode': 'NONE',
    'CRMStatusCode': 'Customer Contacted',
    'CRMStatusValue': 100000002
  },
  {
    'ElectrixStatusCode': 'NONE',
    'MaximoStatusCode': 'DESIGNPRICE',
    'CRMStatusCode': 'Design and Price',
    'CRMStatusValue': 100000003
  },
  {
    'ElectrixStatusCode': 'NONE',
    'MaximoStatusCode': 'QUOTESENT',
    'CRMStatusCode': 'Quote Sent',
    'CRMStatusValue': 100000004
  },
  {
    'ElectrixStatusCode': 'NONE',
    'MaximoStatusCode': 'QUOTEEXPIRED',
    'CRMStatusCode': 'Quote Expired',
    'CRMStatusValue': 100000005
  },
  {
    'ElectrixStatusCode': 'NONE',
    'MaximoStatusCode': 'QUOTEREJECTED',
    'CRMStatusCode': 'Quote Rejected',
    'CRMStatusValue': 100000006
  },
  {
    'ElectrixStatusCode': 'NONE',
    'MaximoStatusCode': 'QUOTEACCEPT',
    'CRMStatusCode': 'Quote Accepted',
    'CRMStatusValue': 100000007
  },
  {
    'ElectrixStatusCode': 'NONE',
    'MaximoStatusCode': 'PAYMENTRCVD',
    'CRMStatusCode': 'Payment Received',
    'CRMStatusValue': 100000008
  },
  {
    'ElectrixStatusCode': 'NONE',
    'MaximoStatusCode': 'DOCSRCVD',
    'CRMStatusCode': 'Documents Received',
    'CRMStatusValue': 100000009
  },
  {
    'ElectrixStatusCode': 'NONE',
    'MaximoStatusCode': 'SITEVISIT',
    'CRMStatusCode': 'Site Visit',
    'CRMStatusValue': 100000010
  },
  {
    'ElectrixStatusCode': 'NONE',
    'MaximoStatusCode': 'CREATEICP',
    'CRMStatusCode': 'Create ICP',
    'CRMStatusValue': 100000011
  },
  {
    'ElectrixStatusCode': 'NONE',
    'MaximoStatusCode': 'RETAILERCONF',
    'CRMStatusCode': 'Retailer Confirmed',
    'CRMStatusValue': 100000012
  },
  {
    'ElectrixStatusCode': 'NONE',
    'MaximoStatusCode': 'WORKPREP',
    'CRMStatusCode': 'Work Prepared',
    'CRMStatusValue': 100000013
  },
  {
    'ElectrixStatusCode': 'NONE',
    'MaximoStatusCode': 'DATECONF',
    'CRMStatusCode': 'Date Confirmed',
    'CRMStatusValue': 100000014
  },
  {
    'ElectrixStatusCode': 'NONE',
    'MaximoStatusCode': 'COMP',
    'CRMStatusCode': 'Connection Complete',
    'CRMStatusValue': 100000015
  },
  {
    'ElectrixStatusCode': 'NONE',
    'MaximoStatusCode': 'INSTALLMETER',
    'CRMStatusCode': 'Install Meter',
    'CRMStatusValue': 100000016
  },
  {
    'ElectrixStatusCode': 'NONE',
    'MaximoStatusCode': 'UPDATEICP',
    'CRMStatusCode': 'Update ICP',
    'CRMStatusValue': 100000017
  },
  {
    'ElectrixStatusCode': 'NONE',
    'MaximoStatusCode': 'REINSTCOMP',
    'CRMStatusCode': 'Reinstatement Complete',
    'CRMStatusValue': 100000018
  },
  {
    'ElectrixStatusCode': 'NONE',
    'MaximoStatusCode': 'GISCOMP',
    'CRMStatusCode': 'GIS Updated',
    'CRMStatusValue': 100000019
  },
  {
    'ElectrixStatusCode': 'Completed',
    'MaximoStatusCode': 'ALLCOMP',
    'CRMStatusCode': 'All Work Complete',
    'CRMStatusValue': 100000020
  },
  {
    'ElectrixStatusCode': 'NONE',
    'MaximoStatusCode': 'CLOSE',
    'CRMStatusCode': 'Closed',
    'CRMStatusValue': 100000021
  },
  {
    'ElectrixStatusCode': 'NONE',
    'MaximoStatusCode': 'NONE',
    'CRMStatusCode': 'Open',
    'CRMStatusValue': 100000022
  },
  {
    'ElectrixStatusCode': 'NONE',
    'MaximoStatusCode': 'NONE',
    'CRMStatusCode': 'Acknowledged',
    'CRMStatusValue': 100000023
  },
  {
    'ElectrixStatusCode': 'NONE',
    'MaximoStatusCode': 'APPR',
    'CRMStatusCode': 'Approved',
    'CRMStatusValue': 100000024
  },
  {
    'ElectrixStatusCode': 'Cancelled',
    'MaximoStatusCode': 'CAN',
    'CRMStatusCode': 'Cancelled',
    'CRMStatusValue': 100000025
  },
  {
    'ElectrixStatusCode': 'NONE',
    'MaximoStatusCode': 'NONE',
    'CRMStatusCode': 'Field - Work Completed',
    'CRMStatusValue': 100000026
  },
  {
    'ElectrixStatusCode': 'NONE',
    'MaximoStatusCode': 'NONE',
    'CRMStatusCode': 'VP - In Process',
    'CRMStatusValue': 100000027
  },
  {
    'ElectrixStatusCode': 'NONE',
    'MaximoStatusCode': 'NONE',
    'CRMStatusCode': 'Responded',
    'CRMStatusValue': 100000028
  },
  {
    'ElectrixStatusCode': 'NONE',
    'MaximoStatusCode': 'QUOTEEXPIRED',
    'CRMStatusCode': 'Quote Expired',
    'CRMStatusValue': 100000029
  },
  {
    'ElectrixStatusCode': 'Accepted',
    'MaximoStatusCode': 'NONE',
    'CRMStatusCode': 'Accepted',
    'CRMStatusValue': 100000030
  },
  {
    'ElectrixStatusCode': 'NONE',
    'MaximoStatusCode': 'NONE',
    'CRMStatusCode': 'Received',
    'CRMStatusValue': 100000031
  },
  {
    'ElectrixStatusCode': 'NONE',
    'MaximoStatusCode': 'NONE',
    'CRMStatusCode': 'Rejected',
    'CRMStatusValue': 100000032
  },
  {
    'ElectrixStatusCode': 'NONE',
    'MaximoStatusCode': 'NONE',
    'CRMStatusCode': 'Dispatched',
    'CRMStatusValue': 100000033
  },
  {
    'ElectrixStatusCode': 'NONE',
    'MaximoStatusCode': 'NONE',
    'CRMStatusCode': 'Service Restored',
    'CRMStatusValue': 100000034
  },
  {
    'ElectrixStatusCode': 'NONE',
    'MaximoStatusCode': 'NONE',
    'CRMStatusCode': 'Problem Solved',
    'CRMStatusValue': 5
  },
  {
    'ElectrixStatusCode': 'NONE',
    'MaximoStatusCode': 'NONE',
    'CRMStatusCode': 'Information Provided',
    'CRMStatusValue': 1000
  },
  {
    'ElectrixStatusCode': 'NONE',
    'MaximoStatusCode': 'NONE',
    'CRMStatusCode': 'Closed - Completed',
    'CRMStatusValue': 100000001
  },
  {
    'ElectrixStatusCode': 'NONE',
    'MaximoStatusCode': 'NONE',
    'CRMStatusCode': 'Canceled',
    'CRMStatusValue': 6
  },
  {
    'ElectrixStatusCode': 'NONE',
    'MaximoStatusCode': 'NONE',
    'CRMStatusCode': 'Merged',
    'CRMStatusValue': 2000
  },
  {
    'ElectrixStatusCode': 'Duplicate',
    'MaximoStatusCode': 'NONE',
    'CRMStatusCode': 'Duplicate',
    'CRMStatusValue': 100000000
  },
  {
    'ElectrixStatusCode': 'Assigned',
    'MaximoStatusCode': 'NONE',
    'CRMStatusCode': 'Assigned',
    'CRMStatusValue': 100000038
  },
  {
    'ElectrixStatusCode': 'Onsite',
    'MaximoStatusCode': 'NONE',
    'CRMStatusCode': 'Onsite',
    'CRMStatusValue': 100000039
  },
  {
    'ElectrixStatusCode': 'Onroute',
    'MaximoStatusCode': 'NONE',
    'CRMStatusCode': 'Onroute',
    'CRMStatusValue': 100000040
  }
]
}";
        #endregion
    }

    public class StatusDictionary
    {
        public string ElectrixStatusCode { get; set; }
        public string MaximoStatusCode { get; set; }
        public string CRMStatusCode { get; set; }
        public int CRMStatusValue { get; set; }
    }