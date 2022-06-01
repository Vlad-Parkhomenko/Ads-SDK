using System.Xml.Serialization;

namespace AdsSdk.Media.Data
{
    [XmlRoot(ElementName = "Creative")]
	public class Creative
	{
		[XmlElement(ElementName = "Linear")]
		public Linear Linear { get; set; }
	}
}