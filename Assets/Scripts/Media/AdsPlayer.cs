using System;
using System.IO;
using System.Xml.Serialization;

using UnityEngine;
using UnityEngine.Video;

using AdsSdk.Media.Data;
using AdsSdk.Networking;

namespace AdsSdk.Media
{
    public class AdsPlayer : MonoBehaviour
    {
        [SerializeField] private VideoPlayer _player;

        private void Start()
        {
            LoadMediaData();
        }

        public void PlayVideo()
        {
            _player.Play();
        }

        private void LoadMediaData()
        {
            NetworkAPI.LoadMediaData(RetrieveVideoURL);
        }

        private void LoadMedia(string url)
        {
            var uri = new Uri(url);
            string path = Application.persistentDataPath + uri.LocalPath;
            NetworkAPI.DownloadMedia(url, data => SaveToDisk(data, path));
        }

        private void RetrieveVideoURL(string xml)
        {
            var serializer = new XmlSerializer(typeof(VAST));

            VAST vast;
            using (StringReader reader = new StringReader(xml))
            {
                vast = (VAST)serializer.Deserialize(reader);
            }

            _player.url = vast.Ad.InLine.Creatives.Creative.Linear.MediaFiles.MediaFile;
            PlayVideo();

            LoadMedia(_player.url);
        }

        private void SaveToDisk(byte[] data, string path)
        {
            File.WriteAllBytes(path, data);
        }
    }
}