using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class coinsUI : MonoBehaviour {
	//usage: put on a cylinder with a trigger
	//intent: destroy coin on collision, and add to a counter
	public Text cointext;
	public Collider coincollider;
	public static int coinsfound = 0;
	
	
	// Use this for initialization
	void Start ()
	{
		cointext.text = "Coins: ";


	}
	
	// Update is called once per frame
	void Update () {
		
		
	}

	private void OnTriggerEnter(Collider coincollider)
	{
		coinsfound++;
		cointext.text = "Coins: " + coinsfound.ToString();
		Destroy(GameObject.FindGameObjectWithTag("coin"));
	}
}
