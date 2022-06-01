using System.Xml.Serialization;

namespace AdsSdk.Media.Data
{
    [XmlRoot(ElementName = "Linear")]
	public class Linear
	{
		[XmlElement(ElementName = "Duration")]
		public string Duration { get; set; }
		[XmlElement(ElementName = "MediaFiles")]
		public MediaFiles MediaFiles { get; set; }
		[XmlElement(ElementName = "TrackingEvents")]
		public string TrackingEvents { get; set; }
	}
}