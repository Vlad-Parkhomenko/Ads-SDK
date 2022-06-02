using System;

using LitJson;

namespace AdsSdk.Purchases.Data
{
    public struct PaymentData
    {
        public string Email { get; set; }
        public string CardNumber { get; set; }
        public DateTime ExpirationDate { get; set; }

        public string ToJson()
        {
            var jsonData = new JsonData
            {
                ["email"] = Email,
                ["card_number"] = CardNumber,
                ["expiration_date"] = ExpirationDate.ToString("MM/yyyy")
            };

            string json = jsonData.ToJson();
            return json;
        }
    }
}