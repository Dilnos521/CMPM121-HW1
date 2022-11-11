// Turns the light component of this object on/off when the user presses and releases the `L` key.
// Source: https://gist.github.com/donovankeith/a8688996d942ee0391f98e4904370c54

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLight : MonoBehaviour {

	Light light;

	// Use this for initialization
	void Start () {
		light = GetComponent<Light> ();
	}

	// Update is called once per frame
	void Update () {
		// Toggle light on/off when L key is pressed.
		if (Input.GetKeyUp (KeyCode.L)) {
			light.enabled = !light.enabled;
		}
	}
}