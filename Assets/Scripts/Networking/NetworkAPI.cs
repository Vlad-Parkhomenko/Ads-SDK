using System;

using UnityEngine.Networking;

using AdsSdk.Purchases.Data;

namespace AdsSdk.Networking
{
    public static class NetworkAPI
    {
        private const string _BaseEndpoint = "https://6u3td6zfza.execute-api.us-east-2.amazonaws.com/prod";

        public static void LoadMediaData(Action<string> successCallback, Action errorCallback = null)
        {
            UnityWebRequest request = RequestCreator.CreateGetRequest($"{_BaseEndpoint}/ad/vast");
            RequestSender.Instance.SendRequest(request, successCallback, errorCallback);
        }

        public static void DownloadMedia(string url, Action<byte[]> successCallBack, Action errorCallback = null)
        {
            UnityWebRequest request = RequestCreator.CreateGetRequest(url);
            RequestSender.Instance.SendRequest(request, successCallBack, errorCallback);
        }

        public static void SendPurchaseRequest(string body, Action<string> successCallback, Action errorCallback = null)
        {
            UnityWebRequest request = RequestCreator.CreatePostRequest($"{_BaseEndpoint}/v1/gcom/ad", body);
            RequestSender.Instance.SendRequest(request, successCallback, errorCallback);
        }

        public static void SendPurchaseConfirmationRequest(PaymentData paymentData, Action<string> successCallback, Action errorCallback = null)
        {
            UnityWebRequest request = RequestCreator.CreatePostRequest($"{_BaseEndpoint}/v1/gcom/action", paymentData.ToJson());
            RequestSender.Instance.SendRequest(request, successCallback, errorCallback);
        }
    }
}
