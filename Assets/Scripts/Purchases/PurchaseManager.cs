using AdsSdk.Networking;
using AdsSdk.Purchases.Data;
using AdsSdk.UI;
using UnityEngine;

namespace AdsSdk.Purchases
{
    public class PurchaseManager : MonoBehaviour
    {
        [SerializeField] private GameObject _productInfoPanel;
        [SerializeField] private PurchaseView _purchaseView;

        private void Start()
        {
            var obj = new { id = 1 };
            string json = JsonUtility.ToJson(obj);
            NetworkAPI.SendPurchaseRequest(json, HandlePurchaseData);
        }

        private void HandlePurchaseData(string json)
        {
            ProductData productData = ProductData.FromJson(json);
            _purchaseView.DisplayProduct(productData);
        }
    }
}
