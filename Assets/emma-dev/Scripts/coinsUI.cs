using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class coinsUI : MonoBehaviour {
	//usage: put on a cylinder with a trigger
	//intent: destroy coin on collision, and add to a counter
	
	//making a singleton!!
	public static coinsUI me;
	
	public Text cointext;
	public Collider coincollider;
	public static int coinsfound = 0;
	
	
	// Use this for initialization
	void Start ()
	{
		cointext.text = "Coins: ";
		me = this;

	}
	
	// Update is called once per frame
	void Update ()
	{

		cointext.text = "Coins: " + coinsfound.ToString();

	}

/*	private void OnTriggerEnter(Collider coincollider)
	{
		coinsfound++;
		cointext.text = "Coins: " + coinsfound.ToString();
		Destroy(GameObject.FindGameObjectWithTag("coin"));
	}*/
	
	//new void can be anything as long as it gets referenced in another script
	//you could put anything here and it'll change the way coins function 
	public void FoundACoin()
	{
		coinsfound++;
	}
}
