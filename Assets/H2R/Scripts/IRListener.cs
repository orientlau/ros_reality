using UnityEngine;
using System;
using System.Collections;

public class IRListener : MonoBehaviour
{


	private WebsocketClient wsc;
	string topic = "ros_unity";

	public float scale = 1f;

	// Use this for initialization
	void Start ()
	{
		GameObject wso = GameObject.FindWithTag ("WebsocketTag");
		wsc = wso.GetComponent<WebsocketClient> ();
		wsc.Subscribe (topic, "std_msgs/String", "none", 0);
	}

	// Update is called once per frame
	//void Update () {

	//}

	void Update () // maybe should be fixed update
	{
 
			string message = wsc.messages[topic];
			Debug.Log(message);
	}


}
