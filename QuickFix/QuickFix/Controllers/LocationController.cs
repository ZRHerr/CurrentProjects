using System.Collections.Generic;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuickFix.Controllers
{
    [Route("api/[controller]")]
    public class LocationController 
    {
        //public string GetLocations()
        //{
        //    var featureCollection = new FeatureCollection();

        //    var point = new Point(new GeographicPosition(34.826973, -77.464111));
        //    var featureProperties = new Dictionary<string, object> { { "NAME", "Zach"}, { "TEL", "000-000-0000" }, { "URL", "http" }, { "ADDRESS1", "000 East Zero St" }, { "CITY", "Jacksonville" } };
        //    var feature = new Feature(point, featureProperties);
        //    featureCollection.Features.Add(feature);
        //    var serializedData = JsonConvert.SerializeObject(featureCollection, Formatting.Indented,
        //       new JsonSerializerSettings
        //       {
        //           NullValueHandling = NullValueHandling.Ignore
        //       });
        //    return serializedData;
        //}
    }
}
