using AdsSdk.Networking.Requests;
using System;
using UnityEngine.Networking;

namespace AdsSdk.Networking
{
    public class NetworkAPI
    {
        private const string _BaseEndpoint = " https://6u3td6zfza.execute-api.us-east-2.amazonaws.com/prod";

        public void LoadMediaData(Action<string> successCallback, Action errorCallback = null)
        {
            UnityWebRequest request = RequestCreator.CreateGetRequest($"{_BaseEndpoint}/ad/vast");
            RequestSender.Instance.SendRequest(request, successCallback, errorCallback);
        }

        public void SendPurchaseRequest(string body, Action<string> successCallback, Action errorCallback = null)
        {
            UnityWebRequest request = RequestCreator.CreatePostRequest($"{_BaseEndpoint}/v1/gcom/ad", body);
            RequestSender.Instance.SendRequest(request, successCallback, errorCallback);
        }

        public void SendPurchaseConfirmationRequest(string body, Action<string> successCallback, Action errorCallback = null)
        {
            UnityWebRequest request = RequestCreator.CreatePostRequest($"{_BaseEndpoint}/v1/gcom/action", body);
            RequestSender.Instance.SendRequest(request, successCallback, errorCallback);
        }
    }
}
