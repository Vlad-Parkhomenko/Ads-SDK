using UnityEngine;

using AdsSdk.Networking;
using AdsSdk.Purchases.Data;
using AdsSdk.UI;

namespace AdsSdk.Purchases
{
    public class PurchaseManager : MonoBehaviour
    {
        [SerializeField] private PurchaseView _purchaseView;
        [SerializeField] private PaymentView _paymentView;

        private void Start()
        {
            _paymentView.PurchaseDataCollected += ConfirmPurchase;
            LoadPurchaseData();
        }

        public void LoadPurchaseData()
        {
            NetworkAPI.SendPurchaseRequest("{}", HandlePurchaseData);
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
