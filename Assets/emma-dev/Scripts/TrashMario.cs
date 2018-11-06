using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashMario : MonoBehaviour {
	//usage: put this on a capsule with a rigidbody
	//intent: moves Trash Mario
	public float moveSpeed = 10f;
	//this variable remembers input and passes it to physics
	private Vector3 inputVector;
	public float LookSpeed = 100f;
	public static TrashMario itsame;
	public int health = 3;

	// Use this for initialization
	void Start ()
	{

		itsame = this;

	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetMouseButtonDown(0)) //0 = left, 1 = right, 2 = middleclick
		{
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
		}
		//----------------------------- 
		//WASD MOVEMENT
		//get axiss returns a float between -1f and 1f. when you're not pressing anything it returns 0f
		float horizontal = Input.GetAxis("Horizontal"); // a d
		float vertical = Input.GetAxis("Vertical"); // w s 
		//apply keyboard input to position
		//when you do this, you're teleporting. no collision detection
		//transform.position += transform.forward * vertical * moveSpeed; //forward
		//transform.position += transform.right * horizontal * moveSpeed; //strafe
		//HAHA SIKE THAT WAS USELESS, BITCH

		//collecting data. remember to use += so it means 'also equals' i guess??
		inputVector = transform.forward * vertical;
		inputVector += transform.right * horizontal;
		
		
	}
	//runs every physics frame (a different framerate than input or rendering or anything else)
	//PUT ALL PHYSICS CODE IN FIXEDUPDATE
	void FixedUpdate()
	{
		//override object's velocity with desired inputVector direction
		GetComponent<Rigidbody>().velocity = inputVector * moveSpeed + Physics.gravity * 0.5f;
	}

	public void TakeDamage()
	{
		health--;
		if (health <= 0)
		{
			Death();
		}
	}

	public void Death()
	{
		
	}
}
