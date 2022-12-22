using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniSense;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Haptics;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

public class DualSense : AbstractDualSenseController {

    private void Awake() {
        DualSenseGamepadHID dualSense = DualSenseGamepadHID.FindCurrent();
        if (dualSense != null) {
            NotifyConnection(dualSense);
            AwakeState();
        } else {
            NotifyDisconnection();
        }
    }

    private void Update() {
        if (IsNull) return;

        UpdateState();
    }

    private void OnEnable() {
        InputSystem.onDeviceChange += OnDeviceChange;
    }

    private void OnDisable() {
        InputSystem.onDeviceChange -= OnDeviceChange;
        var dualSense = DualSenseGamepadHID.FindCurrent();
        dualSense?.Reset();
    }

    private void OnDeviceChange(InputDevice device, InputDeviceChange change) {
        if (!(device is DualSenseGamepadHID)) return;

        switch (change) {
            case InputDeviceChange.Added:
                NotifyConnection(device as DualSenseGamepadHID);
                break;
            case InputDeviceChange.Reconnected:
                NotifyConnection(device as DualSenseGamepadHID);
                break;
            case InputDeviceChange.Disconnected:
                NotifyDisconnection();
                break;
        }
    }

    private void NotifyConnection(DualSenseGamepadHID dualSense) {
        ((IDualSense)this).OnConnect(dualSense);
    }

    private void NotifyDisconnection() {
        ((IDualSense)this).OnDisconnect();
    }

}
