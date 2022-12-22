using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

    [SerializeField] private float mvoeSpeed;

    private DualSense dualSense;

    private void Awake() {
        dualSense = GetComponent<DualSense>();
    }

    private void Update() {
        if (dualSense.IsNull) return;

        Vector3 velocity = transform.position;
                
        if (dualSense.DpadLeft.isPressed) {
            velocity.x -= mvoeSpeed * Time.deltaTime;
        }

        if (dualSense.DpadRight.isPressed) {
            velocity.x += mvoeSpeed * Time.deltaTime;
        }

        if (dualSense.DpadUp.isPressed) {
            velocity.z += mvoeSpeed * Time.deltaTime;
        }

        if (dualSense.DpadDown.isPressed) {
            velocity.z -= mvoeSpeed * Time.deltaTime;
        }

        transform.position = velocity;
    }

}
