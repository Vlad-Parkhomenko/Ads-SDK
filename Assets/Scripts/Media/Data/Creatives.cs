using System.Xml.Serialization;

namespace AdsSdk.Media.Data
{
    [XmlRoot(ElementName = "Creatives")]
	public class Creatives
	{
		[XmlElement(ElementName = "Creative")]
		public Creative Creative { get; set; }
	}
}