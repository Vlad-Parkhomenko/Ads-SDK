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
        [SerializeField] private PaymentView _paymentView;

        private void Start()
        {
            var obj = new { id = 1 };
            string json = JsonUtility.ToJson(obj);
            NetworkAPI.SendPurchaseRequest(json, HandlePurchaseData);
            _paymentView.PurchaseDataCollected += ConfirmPurchase;
        }

        private void HandlePurchaseData(string json)
        {
            ProductData productData = ProductData.FromJson(json);
            _purchaseView.DisplayProduct(productData);
        }

        private void ConfirmPurchase(PaymentData paymentData)
        {
            NetworkAPI.SendPurchaseConfirmationRequest(paymentData, HandlPurchaseConfirmation);
        }

        private void HandlPurchaseConfirmation(string response)
        {
            Debug.Log(response);
        }
    }
}
