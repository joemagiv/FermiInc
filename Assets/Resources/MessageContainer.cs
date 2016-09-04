using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

[XmlRoot("MessageCollection")]
public class MessageContainer {

	[XmlArray("Messages")]
	[XmlArrayItem("Message")]
	public List<Message> messages = new List<Message>();

	public static MessageContainer Load(string path){
		TextAsset _xml = Resources.Load<TextAsset> (path);

		XmlSerializer serializer = new XmlSerializer (typeof(MessageContainer));

		StringReader reader = new StringReader (_xml.text);

		MessageContainer messages = serializer.Deserialize (reader) as MessageContainer;

		reader.Close();

		return messages;
	}
}
