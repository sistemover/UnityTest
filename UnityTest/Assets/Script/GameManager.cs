using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityStandardAssets.CrossPlatformInput;
//using Sistemover.TouchGamePad;

public class GameManager : MonoBehaviour 
{
	public bool A = false;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		//A = CrossPlatformInputManager.GetButtonDown ("A");
		if (A) {
			Debug.Log ("pulsó A");
		}
	}
}
