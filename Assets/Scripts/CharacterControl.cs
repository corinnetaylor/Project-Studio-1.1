using UnityEngine;
using System.Collections;

public class CharacterControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Multiply by Time.deltaTime to ignore verying FPS
		
		/*
		//Key capture, single steps
		if (Input.GetKeyDown (KeyCode.R) == true){
			Debug.Log("Player Pushed the R Key");
			transform.position = transform.position + new Vector3(0f,1f,0f);
		}
		else if (Input.GetKeyDown (KeyCode.F) == true){
			Debug.Log("Player Pushed the F Key");
			transform.position = transform.position + new Vector3(0f,-1f,0f);
		}
		else if (Input.GetKeyDown (KeyCode.W) == true){
			Debug.Log("Player Pushed the W Key");
			transform.Translate(new Vector3(1f,0f,0f));
		}
		else if (Input.GetKeyDown (KeyCode.S) == true){
			Debug.Log("Player Pushed the S Key");
			transform.Translate(new Vector3(-1f,0f,0f));
		}
		else if (Input.GetKeyDown (KeyCode.D) == true){
			Debug.Log("Player Pushed the D Key");
			transform.Translate(new Vector3(0f,0f,-1f));
		}
		else if (Input.GetKeyDown (KeyCode.A) == true){
			Debug.Log("Player Pushed the A Key");
			transform.Translate(new Vector3(0f,0f,1f));
		}
		*/
		
		//Key capture, press down
		if (Input.GetKey (KeyCode.R) == true){
			Debug.Log("Player Pushed the R Key");
			transform.position = transform.position + new Vector3(0f,.5f,0f);
		}
		else if (Input.GetKey (KeyCode.F) == true){
			Debug.Log("Player Pushed the F Key");
			transform.position = transform.position + new Vector3(0f,-.5f,0f);
		}
		else if (Input.GetKey (KeyCode.W) == true){
			Debug.Log("Player Pushed the W Key");
			transform.Translate(new Vector3(.5f,0f,0f));
		}
		else if (Input.GetKey (KeyCode.S) == true){
			Debug.Log("Player Pushed the S Key");
			transform.Translate(new Vector3(-.5f,0f,0f));
		}
		else if (Input.GetKey (KeyCode.D) == true){
			Debug.Log("Player Pushed the D Key");
			transform.Translate(new Vector3(0f,0f,-.5f));
		}
		else if (Input.GetKey (KeyCode.A) == true){
			Debug.Log("Player Pushed the A Key");
			transform.Translate(new Vector3(0f,0f,.5f));
		}
		
	}
}

