#r "Newtonsoft.Json"

using System;
using System.Net;
using Newtonsoft.Json;
using Microsoft.ApplicationInsights;

public static async Task<object> Run(HttpRequestMessage req, TraceWriter log)
{
    log.Info($"Webhook was triggered!");

    string jsonContent = await req.Content.ReadAsStringAsync();
    dynamic logentry = JsonConvert.DeserializeObject(jsonContent);
    
    var tc = new TelemetryClient();
    tc.Context.InstrumentationKey = logentry.Key;
    log.Info($"Instrumentation key {tc.Context.InstrumentationKey}.");
    tc.TrackEvent(logentry.Event.ToString());
    
    return  req.CreateResponse(HttpStatusCode.OK);
}
