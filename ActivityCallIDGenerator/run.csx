#r "Newtonsoft.Json"

using System;
using System.Net;
using Newtonsoft.Json;

public static async Task<object> Run(HttpRequestMessage req, TraceWriter log)
{
    log.Info($"Webhook was triggered!");

    var seed = Guid.NewGuid().ToString();
    var bytes = System.Text.Encoding.UTF8.GetBytes(seed);
    var base64 = Convert.ToBase64String(bytes); 
    var activityid = base64.Replace("+","").Replace("=","").Replace("/","").Substring(0,6).ToUpper();


    return req.CreateResponse(HttpStatusCode.OK, new { activityid });
}
