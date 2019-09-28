using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using ExternalService.Models;
using Microsoft.IdentityModel.Protocols;
using Nancy.Json;
using RestSharp;

namespace ExternalService.GoogleService
{
    public class GoogleService : IGoogleService
    {
        private string SERVER_API_KEY;// = "AIzaSyBWbFUOK5qaKWxN1NDkeJWF0PIzJ5cpL1g";
        private string SENDER_ID;// = "948184623708";
        private string directionApi = "https://maps.googleapis.com/maps/api/directions/";
        private string staticMap = "http://maps.googleapis.com/maps/api/";
        public GoogleService()
        {
            SERVER_API_KEY = ConfigurationManager.AppSettings["ZachsKey"];
            SENDER_ID = ConfigurationManager.AppSettings["ZachsKey"];
        }

        public string SendDriverManagerNotification(string deviceId, string message)
        {
            try
            {
                var value = message;
                WebRequest tRequest;
                tRequest = WebRequest.Create("https://android.googleapis.com/gcm/send");
                tRequest.Method = "post";
                tRequest.ContentType = " application/x-www-form-urlencoded;charset=UTF-8";
                tRequest.Headers.Add(string.Format("Authorization: key={0}", SERVER_API_KEY));

                tRequest.Headers.Add(string.Format("Sender: id={0}", SENDER_ID));

                string postData = "collapse_key=score_update&time_to_live=108&delay_while_idle=1&data.message=" + value + "&data.time=" + System.DateTime.Now.ToString() + "&registration_id=" + deviceId + "";
                Console.WriteLine(postData);
                Byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                tRequest.ContentLength = byteArray.Length;

                Stream dataStream = tRequest.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();

                WebResponse tResponse = tRequest.GetResponse();

                dataStream = tResponse.GetResponseStream();

                StreamReader tReader = new StreamReader(dataStream);

                String sResponseFromServer = tReader.ReadToEnd();


                tReader.Close();
                dataStream.Close();
                tResponse.Close();
                return sResponseFromServer;

            }
            catch (Exception e)
            {
                return e.ToString();
            }

        }

        public GDirectionResponse GetGRoute(GDirectionRequest request, bool alternatives)
        {
            var waypoints = "via:";
            var first = true;
            if (request.WayPoints != null)
            {
                foreach (var point in request.WayPoints)
                {
                    if (!first)
                    {
                        waypoints += "|";
                    }
                    first = false;
                    waypoints += point.Lat + "," + point.Lng;
                }
            }
            var directionResponse = new GDirectionResponse();
            var client = new RestClient(directionApi);
            var restRequest = new RestRequest("json", Method.GET);
            restRequest.AddParameter("origin", request.Src.Lat + "," + request.Src.Lng);
            restRequest.AddParameter("destination", request.Dst.Lat + "," + request.Dst.Lng);
            restRequest.AddParameter("mode", "driving");
            if (request.WayPoints != null && request.WayPoints.Count > 0)
            {
                restRequest.AddParameter("waypoints", waypoints);
                restRequest.AddParameter("waypoints", "optimize:true");
            }
            if (alternatives)
            {
                restRequest.AddParameter("alternatives", "true");
            }
            else
            {
                restRequest.AddParameter("alternatives", "false");
            }

            restRequest.AddParameter("language", "fa");
            IRestResponse response = client.Execute(restRequest);
            JavaScriptSerializer js = new JavaScriptSerializer();

            if (!string.IsNullOrWhiteSpace(response.Content))
            {
                directionResponse = js.Deserialize<GDirectionResponse>(response.Content);
            }
            return directionResponse;
        }

        public string SendNotification(string deviceId, string message)
        {
            var value = message;
            WebRequest tRequest;
            tRequest = WebRequest.Create("https://android.googleapis.com/gcm/send");
            tRequest.Method = "post";
            tRequest.ContentType = " application/x-www-form-urlencoded;charset=UTF-8";
            tRequest.Headers.Add(string.Format("Authorization: key={0}", SERVER_API_KEY));

            tRequest.Headers.Add(string.Format("Sender: id={0}", SENDER_ID));

            string postData = "collapse_key=score_update&delay_while_idle=0&data.message=" + value + "&data.time=" + System.DateTime.Now.ToString() + "&registration_id=" + deviceId + "";
            Console.WriteLine(postData);
            Byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            tRequest.ContentLength = byteArray.Length;

            Stream dataStream = tRequest.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();

            WebResponse tResponse = tRequest.GetResponse();

            dataStream = tResponse.GetResponseStream();

            StreamReader tReader = new StreamReader(dataStream);

            String sResponseFromServer = tReader.ReadToEnd();


            tReader.Close();
            dataStream.Close();
            tResponse.Close();
            return sResponseFromServer;

        }

        public string SendNotification(string deviceId, string title, string message, string action, string selectedTab)
        {
            int thetab;
            int.TryParse(selectedTab, out thetab);
            var value = message;
            WebRequest tRequest;
            tRequest = WebRequest.Create("https://android.googleapis.com/gcm/send");
            tRequest.Method = "post";
            tRequest.ContentType = " application/x-www-form-urlencoded;charset=UTF-8";
            tRequest.Headers.Add(string.Format("Authorization: key={0}", SERVER_API_KEY));

            tRequest.Headers.Add(string.Format("Sender: id={0}", SENDER_ID));

            string postData = "collapse_key=score_update&delay_while_idle=0&data.title=" + title + "&data.body=" + message + "&data.action=" + action + "&data.tab=" + thetab + "&registration_id=" + deviceId + "";
            Console.WriteLine(postData);
            Byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            tRequest.ContentLength = byteArray.Length;

            Stream dataStream = tRequest.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();

            WebResponse tResponse = tRequest.GetResponse();

            dataStream = tResponse.GetResponseStream();

            StreamReader tReader = new StreamReader(dataStream);

            String sResponseFromServer = tReader.ReadToEnd();


            tReader.Close();
            dataStream.Close();
            tResponse.Close();
            return sResponseFromServer;

        }

        public string SendNotification(string deviceId, string title, string message, string action, string selectedTab, int requestCode, int notificationId, string url)
        {
            int thetab;
            int.TryParse(selectedTab, out thetab);
            var value = message;
            WebRequest tRequest;
            tRequest = WebRequest.Create("https://android.googleapis.com/gcm/send");
            tRequest.Method = "post";
            tRequest.ContentType = " application/x-www-form-urlencoded;charset=UTF-8";
            tRequest.Headers.Add(string.Format("Authorization: key={0}", SERVER_API_KEY));

            tRequest.Headers.Add(string.Format("Sender: id={0}", SENDER_ID));
            string postData = "";

            if (!string.IsNullOrEmpty(url))
            {
                postData = "collapse_key=score_update&delay_while_idle=0&data.title=" + title + "&data.body=" + message + "&data.action=" + action + "&data.tab=" + thetab + "&data.requestCode=" + requestCode + "&data.notificationId=" + notificationId + "&data.link=" + url + "&registration_id=" + deviceId + "";
            }
            else
            {
                postData = "collapse_key=score_update&delay_while_idle=0&data.title=" + title + "&data.body=" + message + "&data.action=" + action + "&data.tab=" + thetab + "&data.requestCode=" + requestCode + "&data.notificationId=" + notificationId + "&registration_id=" + deviceId + "";
            }

            Console.WriteLine(postData);
            Byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            tRequest.ContentLength = byteArray.Length;

            Stream dataStream = tRequest.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();

            WebResponse tResponse = tRequest.GetResponse();

            dataStream = tResponse.GetResponseStream();

            StreamReader tReader = new StreamReader(dataStream);

            String sResponseFromServer = tReader.ReadToEnd();


            tReader.Close();
            dataStream.Close();
            tResponse.Close();
            return sResponseFromServer;

        }

        public string SendGroupNotification(List<string> deviceIds, string title, string message, string action, string selectedTab, string url)
        {
            var value = message;
            WebRequest tRequest;
            tRequest = WebRequest.Create("https://android.googleapis.com/gcm/send");
            tRequest.Method = "post";
            //tRequest.ContentType = " application/x-www-form-urlencoded;charset=UTF-8";
            tRequest.ContentType = "application/json";
            tRequest.Headers.Add(string.Format("Authorization: key={0}", SERVER_API_KEY));

            tRequest.Headers.Add(string.Format("Sender: id={0}", SENDER_ID));

            //string postData = "collapse_key=score_update&delay_while_idle=0&data.title=" + title + "&data.body=" + message + "&data.action=" + action + "&data.tab=" + selectedTab + "&registration_ids=" + string.Join(",", deviceIds) + "";
            string postData = "{\"collapse_key\":\"score_update\",\"delay_while_idle\":false,\"data\": { \"title\" : " + "\"" + title + "\",\"body\": " + "\"" + message + "\",\"action\": " + "\"" + action + "\",\"tab\": " + "\"" + selectedTab + "\",\"link\": " + "\"" + url + "\"},\"registration_ids\":[\"" + string.Join("\",\"", deviceIds) + "\"]}";
            //Console.WriteLine(postData);
            Byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            tRequest.ContentLength = byteArray.Length;

            Stream dataStream = tRequest.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();

            WebResponse tResponse = tRequest.GetResponse();

            dataStream = tResponse.GetResponseStream();

            StreamReader tReader = new StreamReader(dataStream);

            String sResponseFromServer = tReader.ReadToEnd();


            tReader.Close();
            dataStream.Close();
            tResponse.Close();
            return sResponseFromServer;

        }


        public byte[] GetMapImage(GDirectionRequest request)
        {


            var client = new RestClient(staticMap);
            var restRequest = new RestRequest("staticmap", Method.GET);
            restRequest.AddParameter("size", "600x300");
            restRequest.AddParameter("format", "JPEG");
            restRequest.AddParameter("maptype", "roadmap");
            restRequest.AddParameter("language", "fa");
            var marker = "color:green|label:S|";
            marker += request.Src.Lat + "," + request.Src.Lng + "|";
            restRequest.AddParameter("markers", marker);
            marker = "color:green|label:D|";
            marker += request.Dst.Lat + "," + request.Dst.Lng;
            restRequest.AddParameter("markers", marker);

            var path = "color:red|weight:5";
            if (request.WayPoints != null && request.WayPoints.Count > 0)
            {
                foreach (var point in request.WayPoints)
                {
                    path += "|";
                    path += point.Lat + "," + point.Lng;
                }
            }
            else
            {
                path += "|" + request.Src.Lat + "," + request.Src.Lng + "|" + request.Dst.Lat + "," + request.Dst.Lng;
            }
            restRequest.AddParameter("path", path);

            var res = client.DownloadData(restRequest);

            return res;
        }
    }
}
