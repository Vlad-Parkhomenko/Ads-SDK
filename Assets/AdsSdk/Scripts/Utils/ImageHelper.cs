using UnityEngine;
using UnityEngine.UI;

namespace AdsSdk.Utils
{
    public static class ImageHelper
    {
        public static void SetImage(byte[] imageBytes, Image image)
        {
            var texture = new Texture2D(0, 0);
            texture.LoadImage(imageBytes);
            image.sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f));
        }
    }
}