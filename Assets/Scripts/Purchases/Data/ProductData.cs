using AdsSdk.Purchases.Enums;
using LitJson;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AdsSdk.Purchases.Data
{
    public struct ProductData
    {
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
                itemId = data["item_id"].ToString(),
                title = data["title"].ToString(),
                itemName = data["item_name"].ToString(),
                imageLink = data["item_image"].ToString(),
                price = float.Parse(data["price"].ToString()),
                currencySign = data["currency_sign"].ToString(),
            };

            string currencyString = data["currency"].ToString();
            
            if(!Enum.TryParse(currencyString, out productData.currency))
            {
                Debug.LogError("Invalid string for currency convertion");
            }

            return productData;
        }
    }
}