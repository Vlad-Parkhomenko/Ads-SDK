using AdsSdk.Purchases.Data;
using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

namespace AdsSdk.UI
{
    public class PaymentView : MonoBehaviour
    {
        [SerializeField] private InputField _email;
        [SerializeField] private InputField _creditCardNumber;
        [SerializeField] private InputField _cardExpirationDate;
        [SerializeField] private Button _confirm;

        public event Action<PaymentData> PurchaseDataCollected;

        private void Awake()
        {
            _confirm.onClick.AddListener(CaptureData);
        }

        private void CaptureData()
        {
            var paymentData = new PaymentData
            {
                Email = _email.text,
                CardNumber = _creditCardNumber.text,
                ExpirationDate = DateTime.ParseExact(_cardExpirationDate.text, "MM/yyyy", CultureInfo.InvariantCulture)
            };

            PurchaseDataCollected?.Invoke(paymentData);
        }
    }

}