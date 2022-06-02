using AdsSdk.Purchases.Data;
using AdsSdk.UI.Validation;
using System;
using System.Globalization;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace AdsSdk.UI
{
    public class PaymentView : MonoBehaviour
    {
        [SerializeField] private EmailValidator _email;
        [SerializeField] private CardNumberValidator _cardNumber;
        [SerializeField] private DateValidator _cardExpirationDate;
        [SerializeField] private Button _confirm;

        private FieldValidator[] _validators;

        public event Action<PaymentData> PurchaseDataCollected;

        private void Awake()
        {
            _validators = new FieldValidator[] { _email, _cardNumber,_cardExpirationDate };
            _confirm.onClick.AddListener(CaptureData);
        }

        private void CaptureData()
        {
            if (!IsValid())
            {
                return;
            }

            var paymentData = new PaymentData
            {
                Email = _email.InputField.text,
                CardNumber = _cardNumber.InputField.text,
                ExpirationDate = DateTime.ParseExact(_cardExpirationDate.InputField.text, _cardExpirationDate.DateFormat, CultureInfo.InvariantCulture)
            };

            PurchaseDataCollected?.Invoke(paymentData);
        }

        private bool IsValid()
        {
            /*if (!_email.IsValid())
            {
                return false;
            }
            if (!_cardNumber.IsValid())
            {
                return false;
            }
            if (!_cardExpirationDate.IsValid())
            {
                return false;
            }*/

            return _validators.All(validator => validator.IsValid());
        }
    }

}