using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace QuickStartMSAL
{
	// using System.Xml.Serialization;
	// XmlSerializer serializer = new XmlSerializer(typeof(Subscriber));
	// using (StringReader reader = new StringReader(xml))
	// {
	//    var test = (Subscriber)serializer.Deserialize(reader);
	// }

	[XmlRoot(ElementName = "send-notifications")]
	public class Sendnotifications
	{

		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }

		[XmlText]
		public bool Text { get; set; }
	}

	[XmlRoot(ElementName = "topic")]
	public class Topic
	{

		[XmlElement(ElementName = "code")]
		public string Code { get; set; }
	}

	[XmlRoot(ElementName = "topics")]
	public class Topics
	{

		[XmlElement(ElementName = "topic")]
		public List<Topic> Topic { get; set; }

		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }

		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "subscriber")]
	public class Subscriber
	{

		[XmlElement(ElementName = "email")]
		public string Email { get; set; }

		[XmlElement(ElementName = "send-notifications")]
		public Sendnotifications Sendnotifications { get; set; }

		[XmlElement(ElementName = "topics")]
		public Topics Topics { get; set; }
	}


}
