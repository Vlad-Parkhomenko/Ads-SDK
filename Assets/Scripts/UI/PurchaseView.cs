using UnityEngine;
using UnityEngine.UI;

using AdsSdk.Networking;
using AdsSdk.Purchases.Data;
using AdsSdk.Utils;

namespace AdsSdk.UI
{
    public class PurchaseView : MonoBehaviour
    {
        [SerializeField] private Text _title;
        [SerializeField] private Text _name;
        [SerializeField] private Text _price;
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