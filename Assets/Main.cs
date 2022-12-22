using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

    [SerializeField] private float mvoeSpeed;

    private DualSense dualSense;

    private void Awake() {
        dualSense = GetComponent<DualSense>();
    }

    private void Start() {
        dualSense.LeftContinuousForce = 1f;
        dualSense.LeftContinuousStartPosition = 0f;
        
        dualSense.LeftSectionForce = 1f;
        dualSense.LeftSectionStartPosition = 0f;
        dualSense.LeftSectionEndPosition = 1f;

        dualSense.LeftEffectStartPosition = 0f;
        dualSense.LeftEffectBeginForce = 0f;
        dualSense.LeftEffectMiddleForce = 0f;
        dualSense.LeftEffectEndForce = 0f;
        dualSense.LeftEffectFrequency = 0f;
        dualSense.LeftEffectKeepEffect = false;
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
