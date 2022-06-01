using AdsSdk.Networking;
using UnityEngine;

namespace AdsSdk.Media
{
    public class MediaManager : MonoBehaviour
    {
        private NetworkAPI _api = new NetworkAPI();

        private void Start()
        {
            LoadMediaData();
        }

        private void LoadMediaData()
        {
            _api.LoadMediaData(HandleMediaLoading);
        }

        private void HandleMediaLoading(string xml)
        {
            Debug.Log(xml);
        }
    }
}