using System.Xml.Serialization;

namespace AdsSdk.Media.Data
{
	[XmlRoot(ElementName = "VAST")]
	public struct VAST
	{
		[XmlElement(ElementName = "Ad")]
		public Ad Ad { get; set; }
		[XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Xsi { get; set; }
		[XmlAttribute(AttributeName = "xsd", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Xsd { get; set; }
		[XmlAttribute(AttributeName = "version")]
		public string Version { get; set; }
	}
}