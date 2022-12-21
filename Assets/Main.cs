using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

    private DualSense dualSense = new DualSense();

    private void Start() {
        dualSense.Init();
    }

    private void Update() {
        dualSense.UpdateButton();

        Debug.Log(dualSense.DpadUp.isPressed);
    }

    private void OnEnable() {
        dualSense.Enable();
    }

    private void OnDisable() {
        dualSense.Disable();
    }

}
