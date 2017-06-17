using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store : MonoBehaviour {

	bool mouseDown = false;

	void OnMouseDown() {
		mouseDown = true;
	}

	void OnGUI()
	{
		if (mouseDown) {

			//layout start
			GUI.BeginGroup (new Rect (Screen.width / 2 - 150, 50, 300, 250));

			//the menu background box
			GUI.Box (new Rect (0, 0, 300, 250), "");

			// Information text
			GUI.Label (new Rect (15, 10, 300, 68), "Do you want to go into the store?");

			//Player wants to leave this location
			if (GUI.Button (new Rect (55, 100, 180, 40), "Go In!")) {
				mouseDown = false;
			}
			// The following line is commented out for now
			// as we have nowhere to go :D
			//Application.LoadLevel(1);
			//Player wants to stay at this location
			if (GUI.Button (new Rect (55, 150, 180, 40), "Stay")) {
				mouseDown = false;
			}

			//layout end
			GUI.EndGroup ();
		}
	}
}
