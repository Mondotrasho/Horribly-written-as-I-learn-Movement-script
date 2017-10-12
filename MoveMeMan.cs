using UnityEngine;
using System.Collections;

public class MoveMeMan : MonoBehaviour {
	
	
	
	public static Vector2 right;

	public float addnoodles;
	public bool noodles;
	//public float 
	void Start () {
		//addnoodles = 0f;
		bool noodles = Input.GetButton("jump") ;	
		float addnoodles = noodles ? 1 : 0;
	}
	

	//trying to use unity shorthand aka Vector.Right for Vector2(2,0)
	//vector.right won't work neither will getkey.rightarrow cannot find the right way to ask for it
	
	// need to learn wth delta time is
	//No.f etc
	// check https://gamedev.stackexchange.com/questions/13008/how-to-get-and-use-delta-time and https://unity3d.com/learn/tutorials/topics/scripting/delta-time
	void Update () {

		//found out that Unity uses get axis to read from wasd and arrows even reads from Xinput devices
		// https://docs.unity3d.com/Manual/class-InputManager.html
		//
		//always add ;
	

			
		//instead of using if this happens do X u use GetAxis Which feels Cheaty
		// what GetAxis does is quickly changes its value to 1 from 0 in .025 chunks (about) 
		//it knows "Horizontal" is a and d etc
		//So input.GetAxis("Horizontal")*Time.deltaTime is once pressed 1*deltatime but only when D is pressed
		transform.Translate(Input.GetAxis("Horizontal"),addnoodles,Input.GetAxis("Vertical"));

		//when googling found out other people use delta time but considering I only found out in other 
		//peoples code will leave it commented out for now
		//transform.Translate(Input.GetAxis("Horizontal")*Time.deltaTime,0f,Input.GetAxis("Vertical")*Time.deltaTime);
		//So input.GetAxis("Horizontal")*Time.deltaTime is once pressed 1*deltatime but only when D is pressed

		//new start below is failed
		
		print (Input.GetAxis("Vertical"));
		//if(Input.GetButtonDown (KeyCode.RightArrow));
	//if(Input.GetKey(KeyCode.RightArrow));
		//transform.Translate(1f*Time.deltaTime,0f,0f);
		//transform.position = new Vector3(1f*Time.deltaTime,0f,0f);
		
		//turns out the f just means its a float so its got deciamls points 

		// and Delta time is a framerate based measure of difference not completely sure but its there so that
		// if I run this code on a toaster things move at the same speed regardless of how fast the machine 
		// renders it
		
		//vector 3 is a unity thing so its 3 vectors ie X Y Z Vector 2 would be X and Y I guess
		//translate(0f.1f*deltatime.0f) moves up guess I could use 0.1f*deltatime.0 don't really know what the 
		//difference would be if its not moving maybe Vector3 only understands float
		
		
		//	if(Input.GetKey(KeyCode.RightArrow));
		//	gameObject.transform;
}
}
