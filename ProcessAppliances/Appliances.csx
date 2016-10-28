#r "Newtonsoft.Json"

using System;
using System.Net;
using Newtonsoft.Json;

public class Appliance
{
    public string applianceid { get; set; }
    public string name { get; set; }
    public int estquantity { get; set; }
    public string comments { get; set; }
    public string icp { get; set; }
    public string applianceitem {get; set; }
}
