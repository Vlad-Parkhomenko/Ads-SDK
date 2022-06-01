using System.Xml.Serialization;

namespace AdsSdk.Media.Data
{
	[XmlRoot(ElementName = "MediaFiles")]
	public struct MediaFiles
	{
		[XmlElement(ElementName = "MediaFile")]
		public string MediaFile { get; set; }
	}
}
