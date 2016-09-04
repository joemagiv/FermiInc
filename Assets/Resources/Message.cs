using UnityEngine;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;

public class Message {

	[XmlAttribute("ID")]
	public int ID;

	[XmlElement("FromString")]
	public string fromString;

	[XmlElement("DateString")]
	public string dateString;

	[XmlElement("SubjectString")]
	public string subjectString;

	[XmlElement("BodyString")]
	public string bodyString;

	[XmlElement("DayAdded")]
	public int dayAdded;

	[XmlElement("PlayerEmail")]
	public bool playerEmail;
}
