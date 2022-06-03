using System.Xml.Serialization;

namespace AdsSdk.Media.Data
{
    [XmlRoot(ElementName = "Creative")]
	public struct Creative
	{
		[XmlElement(ElementName = "Linear")]
		public Linear Linear { get; set; }
	}
}