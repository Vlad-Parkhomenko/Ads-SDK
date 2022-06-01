using System;
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
            if (string.IsNullOrEmpty(body))
            {
                throw new ArgumentNullException("POST request body can not be empty. Pass the valid JSON string");
            }

            var request = UnityWebRequest.Post(url, body);

            return request;
        }
    }
}