using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

namespace AdsSdk.Networking
{
    public class RequestSender : MonoBehaviour
    {
        public static RequestSender Instance { get; private set; }

        private void Awake()
        {
            if (Instance != null)
            {
                Debug.LogError("RequestManager singleton dupplication");
                Destroy(this);
                return;
            }

            Instance = this;
            DontDestroyOnLoad(Instance);
        }

        public void SendRequest(UnityWebRequest request, Action<string> successCallback, Action errorCallback = null)
        {
            StartCoroutine(SendRequestCoroutine(request, successCallback, errorCallback));
        }

        private IEnumerator SendRequestCoroutine(UnityWebRequest request, Action<string> successCallback, Action errorCallback = null)
        {
            yield return request.SendWebRequest();

            if (request.isNetworkError || request.isHttpError)
            {
                Debug.LogError(request.error);
                errorCallback?.Invoke();
            }
            else
            {
                successCallback?.Invoke(request.downloadHandler.text);
            }
        }
    }
}

