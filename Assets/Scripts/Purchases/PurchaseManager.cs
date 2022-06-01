using AdsSdk.Networking;
using UnityEngine;

namespace AdsSdk.Purchases
{
    public class PurchaseManager : MonoBehaviour
    {
        [SerializeField] private GameObject _productInfoPanel;

        private NetworkAPI _api = new NetworkAPI();

        private void Start()
        {
            var obj = new { id = 1 };
            string json = JsonUtility.ToJson(obj);
            _api.SendPurchaseRequest(json, HandlePurchaseData);
        }

        private void HandlePurchaseData(string json)
        {
            Debug.Log(json);
        }
    }
}
