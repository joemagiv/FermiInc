using UnityEngine;
using System.Collections;

public class MessageLoader : MonoBehaviour {

	public GameObject messagePrefab;
	public GameObject messagesParent;
	public const string path = "messages";

	// Use this for initialization
	void Start () {

	}
	

	public void PopulateMessages (bool playerEmails, int currentDate)
	{
		MessageContainer mc = MessageContainer.Load (path);
		Vector3 startingMessageParentPosition = messagesParent.transform.position;
		Vector3 messageParentPosition = messagesParent.transform.position;
		if (playerEmails) {
			foreach (Message message in mc.messages) {
				if (message.playerEmail) {
					if (currentDate == message.dayAdded) {
						GameObject newMessage = Instantiate (messagePrefab, messageParentPosition, messagesParent.transform.rotation) as GameObject;
						newMessage.transform.parent = messagesParent.transform;
						MessageObject messageObject = newMessage.GetComponent<MessageObject> ();
						messageObject.dateText.text = message.dateString;
						messageObject.fromText.text = message.fromString;
						messageObject.subjectText.text = message.subjectString;
						messageObject.bodyTextString = message.bodyString;
						messageParentPosition.y = messageParentPosition.y - 35;
					}
				}
			}
		} else {
			foreach (Message message in mc.messages) {
				if (!message.playerEmail) {
					if (currentDate == message.dayAdded) {
						GameObject newMessage = Instantiate (messagePrefab, messageParentPosition, messagesParent.transform.rotation) as GameObject;
						newMessage.transform.parent = messagesParent.transform;
						MessageObject messageObject = newMessage.GetComponent<MessageObject> ();
						messageObject.dateText.text = message.dateString;
						messageObject.fromText.text = message.fromString;
						messageObject.subjectText.text = message.subjectString;
						messageObject.bodyTextString = message.bodyString;
						messageParentPosition.y = messageParentPosition.y - 35;
					}
				}
			}
		}
	}
}
