using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    private DualSenseMain dualSense = new DualSenseMain();

    private void Update() {
        if (dualSense.dpadUp) {
            Debug.Log("Dpad UP isPressed");
        }
    }

}
