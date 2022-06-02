using AdsSdk.Networking;
using AdsSdk.Purchases.Data;
using AdsSdk.Utils;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace AdsSdk.UI
{
    public class PurchaseView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _title;
        [SerializeField] private TMP_Text _name;
        [SerializeField] private TMP_Text _price;
        [SerializeField] private Image _productImage;
        [SerializeField] private Button _confirm;

        private void Awake()
        {
            _productImage.preserveAspect = true;
        }

        public void DisplayProduct(ProductData productData)
        {
            _title.text = productData.title;
            _name.text = productData.itemName;
            _price.text = $"{productData.currencySign} {productData.price}";

            NetworkAPI.DownloadMedia(productData.imageLink, imageBytes => ImageHelper.SetImage(imageBytes, _productImage));
        }
    }
}