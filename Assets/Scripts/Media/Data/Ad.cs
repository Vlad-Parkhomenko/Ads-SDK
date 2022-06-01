using System.Xml.Serialization;

namespace AdsSdk.Media.Data
{
    [XmlRoot(ElementName = "Ad")]
	public class Ad
	{
		[XmlElement(ElementName = "InLine")]
		public InLine InLine { get; set; }
	}
}