using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace AdsSdk.Networking.Requests
{
    public static class RequestCreator
    {
        public static UnityWebRequest CreateGetRequest(string url)
        {
            var request = UnityWebRequest.Get(url);

            return request;
        }

        public static UnityWebRequest CreatePostRequest(string url, string body)
        {
            var request = UnityWebRequest.Post(url, body);

            return request;
        }
    }
}