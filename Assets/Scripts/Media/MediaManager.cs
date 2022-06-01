﻿using AdsSdk.Media.Data;
using AdsSdk.Networking;
using System.IO;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.Video;

namespace AdsSdk.Media
{
    public class MediaManager : MonoBehaviour
    {
        [SerializeField] private VideoPlayer _player;

        private NetworkAPI _api = new NetworkAPI();

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
            _api.LoadMediaData(RetrieveVideoURL);
        }

        private void RetrieveVideoURL(string xml)
        {
            Debug.Log(xml);

            var serializer = new XmlSerializer(typeof(VAST));

            VAST vast;
            using (StringReader reader = new StringReader(xml))
            {
                vast = (VAST)serializer.Deserialize(reader);
            }

            _player.url = vast.Ad.InLine.Creatives.Creative.Linear.MediaFiles.MediaFile;
            PlayVideo();
        }
    }
}