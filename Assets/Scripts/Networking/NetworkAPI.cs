using System;

using UnityEngine.Networking;

using AdsSdk.Purchases.Data;
using UnityEngine;

namespace AdsSdk.Networking
{
    public static class NetworkAPI
    {
        private const string _BaseEndpoint = "https://6u3td6zfza.execute-api.us-east-2.amazonaws.com/prod";
        private const string _MediaDataEndpoint = "ad/vast";
        private const string _PurchaseRequestEndpoint = "v1/gcom/ad";
        private const string _PurchaseConfirmationEndpoint = "v1/gcom/action";

        static NetworkAPI()
        {
            RequestSender requestSender = Resources.Load<RequestSender>(nameof(RequestSender));
            UnityEngine.Object.Instantiate(requestSender);
        }

        public static void LoadMediaData(Action<string> successCallback, Action errorCallback = null)
        {
            UnityWebRequest request = RequestCreator.CreateGetRequest($"{_BaseEndpoint}/{_MediaDataEndpoint}");
            RequestSender.Instance.SendRequest(request, successCallback, errorCallback);
        }

        public static void DownloadMedia(string url, Action<byte[]> successCallBack, Action errorCallback = null)
        {
            UnityWebRequest request = RequestCreator.CreateGetRequest(url);
            RequestSender.Instance.SendRequest(request, successCallBack, errorCallback);
        }

        public static void SendPurchaseRequest(string body, Action<string> successCallback, Action errorCallback = null)
        {
            UnityWebRequest request = RequestCreator.CreatePostRequest($"{_BaseEndpoint}/{_PurchaseRequestEndpoint}", body);
            RequestSender.Instance.SendRequest(request, successCallback, errorCallback);
        }

        public static void SendPurchaseConfirmationRequest(PaymentData paymentData, Action<string> successCallback, Action errorCallback = null)
        {
            UnityWebRequest request = RequestCreator.CreatePostRequest($"{_BaseEndpoint}/{_PurchaseConfirmationEndpoint}", paymentData.ToJson());
            RequestSender.Instance.SendRequest(request, successCallback, errorCallback);
        }
    }
}
