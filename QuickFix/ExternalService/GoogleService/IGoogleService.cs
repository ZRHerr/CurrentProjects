using ExternalService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExternalService.GoogleService
{
    public interface IGoogleService
    {
        string SendDriverManagerNotification(string deviceId, string message);
        GDirectionResponse GetGRoute(GDirectionRequest request, bool alternatives);
        string SendNotification(string gtokenKey, string suggestRoute);
        string SendNotification(string gtokenKey, string title, string message, string action, string selectedTab);
        string SendGroupNotification(List<string> deviceIds, string title, string message, string action, string selectedTab, string url);
        byte[] GetMapImage(GDirectionRequest request);
        string SendNotification(string gtokenKey, string encodedTitle, string message, string action, string selectedTab, int requestCode, int notificationId, string url);
    }
}
