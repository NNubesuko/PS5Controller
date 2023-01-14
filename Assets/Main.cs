using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniSense;

public class Main : MonoBehaviour {

    [SerializeField] private float mvoeSpeed;
    [SerializeField] private DualSenseTriggerEffectType effectType;
    [SerializeField] private float startPosition;
    [SerializeField] private float force;

    private DualSense dualSense;

    private void Awake() {
        dualSense = GetComponent<DualSense>();
    }

    private void Start() {
        // dualSense.LeftTriggerEffectType = effectType;
    }

    private void Update() {
        if (dualSense.IsNull) return;

        dualSense.LeftContinuousStartPosition = startPosition;
        dualSense.LeftContinuousForce = force;

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
