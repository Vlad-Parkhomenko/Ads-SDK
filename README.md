# **Ads-SDK**

## **General**
To use the package, download AdsSdk.unitypackage in Release and import it into the project. Required tools are in Prefabs folder. Usage demos are in Samples folder.

### **NetworkAPI**
Utility class for sending requests to the backend in convenint way.
- `LoadMediaData(Action<string> successCallback, Action errorCallback = null)` - sends request for loading XML containing media data. In `successCallback`, this XML is handled.
- `DownloadMedia(string url, Action<byte[]> successCallBack, Action errorCallback = null)` - downloads media file with provided URL. In `successCallBack`, raw medi data is handled.
- `SendPurchaseRequest(string body, Action<string> successCallback, Action errorCallback = null)` - sends request for item purchse. Currently, body is any valid JSON string. In `successCallback`, response JSON of purchse is handled.
- `SendPurchaseConfirmationRequest(PaymentData paymentData, Action<string> successCallback, Action errorCallback = null)` - sends request for purchase confirmation. Accepts payment info. In `successCallback`, purchase result is handled.

### **RequestCreator**
Utility class for simple creating GET and POST requests.
- `CreateGetRequest(string url)` - returns `UnityWebRequest` for GET.
- `CreatePostRequest(string url, string body)` - returns `UnityWebRequest` for POST. `body` is supposed to be a JSON string. Any attempts to pass empty body cause `ArgumentNullException`.
 
## **AdsPlayer**
For playing videos, drag `AdsPlayer.prefab` on the scene. There is no need to use main camera.

### **Methods**
- `PlayVideo` - forcely plays ads video.

## **Purchase Manager**
Drag `PurchaseManager.prefab` on the scene. It will load and display purchase details on UI. On 'Confirm Purchase' click, fields with email, creadit card number and expirtion date are validated. If fields are filled correctly, the payment data is gathered and request for purchase confirmation is sent.

### **Methods**
- `LoadPurchaseData` - forcely loads purchase data.