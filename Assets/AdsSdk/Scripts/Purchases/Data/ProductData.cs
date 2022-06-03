using System;

using LitJson;
using UnityEngine;

using AdsSdk.Purchases.Enums;

namespace AdsSdk.Purchases.Data
{
    public struct ProductData
    {
        private const string _IdKey = "item_id";
        private const string _ItemNameKey = "item_name";
        private const string _ItemImageKey = "item_image";
        private const string _CurrencySignKey = "currency_sign";

        public string itemId;
        public string title;
        public string itemName;
        public string imageLink;
        public float price;
        public string currencySign;
        public Currency currency;

        public static ProductData FromJson(string json)
        {
            JsonData data = JsonMapper.ToObject(json);

            var productData = new ProductData
            {
                itemId = data[_IdKey].ToString(),
                title = data[nameof(title)].ToString(),
                itemName = data[_ItemNameKey].ToString(),
                imageLink = data[_ItemImageKey].ToString(),
                price = float.Parse(data[nameof(price)].ToString()),
                currencySign = data[_CurrencySignKey].ToString(),
            };

            string currencyString = data[nameof(currency)].ToString();
            
            if(!Enum.TryParse(currencyString, out productData.currency))
            {
                Debug.LogError("Invalid string for currency convertion");
            }

            return productData;
        }
    }
}