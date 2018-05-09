using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using UnityEngine.UI;

public class ShowIP : MonoBehaviour
{
	void Start () {
		string IP = Network.player.ipAddress;
		Text text = GetComponent<Text>();
		text.text = "IP:\n" + IP;
	}
}
