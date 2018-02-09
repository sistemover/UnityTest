using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sistemover.TouchGamePad;

public class InputManager : MonoBehaviour {

	public bool d_x,d_y,d_a,d_b,u_x,u_y,u_a,u_b;
	public Vector2 AxisL, AxisR;

	public void FixedTick()
	{
		FixedGetInput();

		Debug.Log ("HR: " + AxisR.x + " | " + "VR: " + AxisR.y);
	}

	public void Tick()
	{

	}

	void FixedGetInput()
	{
		AxisL = new Vector2 (CrossPlatformInputManager.GetAxis ("Horizontal L"), CrossPlatformInputManager.GetAxis ("Vertical L"));
		AxisR = new Vector2 (CrossPlatformInputManager.GetAxis ("Horizontal R"), CrossPlatformInputManager.GetAxis ("Vertical R"));
	}

	void GetInput()
	{

	}
}
