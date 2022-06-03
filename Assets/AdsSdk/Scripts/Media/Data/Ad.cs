using System.Xml.Serialization;

namespace AdsSdk.Media.Data
{
    [XmlRoot(ElementName = "Ad")]
	public struct Ad
	{
		[XmlElement(ElementName = "InLine")]
		public InLine InLine { get; set; }
	}
}