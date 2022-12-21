using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

    private DualSense dualSense;

    private void Awake() {
        dualSense = GetComponent<DualSense>();
    }

    private void Start() {
        StartCoroutine(Moter());
    }

    private void Update() {
        if (dualSense.IsNull) return;
    }

    private IEnumerator Moter() {
        while (true) {
            if (dualSense.DpadLeft.wasPressedThisFrame) {
                dualSense.LeftMoter = 0.1f;
                yield return new WaitForSeconds(1.0f);
            }

            if (dualSense.DpadRight.wasPressedThisFrame) {
                dualSense.RightMoter = 0.1f;
                yield return new WaitForSeconds(1.0f);
            }

            yield return null;
            dualSense.LeftMoter = 0f;
            dualSense.RightMoter = 0f;
        }
    }

}
