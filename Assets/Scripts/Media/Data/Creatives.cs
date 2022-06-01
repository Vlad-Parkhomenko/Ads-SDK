using System.Xml.Serialization;

namespace AdsSdk.Media.Data
{
    [XmlRoot(ElementName = "Creatives")]
	public struct Creatives
	{
		[XmlElement(ElementName = "Creative")]
		public Creative Creative { get; set; }
	}
}