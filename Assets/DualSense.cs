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

    public ButtonControl Cross { get; private set; }
    public ButtonControl Square { get; private set; }
    public ButtonControl Circle { get; private set; }
    public ButtonControl Triangle { get; private set; }

    public ButtonControl R1 { get; private set; }
    public ButtonControl R2 { get; private set; }
    public ButtonControl R3 { get; private set; }

    public ButtonControl L1 { get; private set; }
    public ButtonControl L2 { get; private set; }
    public ButtonControl L3 { get; private set; }

    public ButtonControl Share { get; private set; }
    public ButtonControl Option { get; private set; }
    public ButtonControl Touchpad { get; private set; }

    public DpadControl Dpad { get; private set; }
    public ButtonControl DpadUp { get; private set; }
    public ButtonControl DpadLeft { get; private set; }
    public ButtonControl DpadRight { get; private set; }
    public ButtonControl DpadDown { get; private set; }

    public bool LeftStick { get; private set; }
    public bool RightStick { get; private set; }

    public ButtonControl MicMute { get; private set; }

    public void Init() {
        Debug.Log("Base Start");
        DualSenseGamepadHID dualSense = DualSenseGamepadHID.FindCurrent();
        if (dualSense != null) {
            NotifyConnection(dualSense);
        } else {
            NotifyDisconnection();
        }
    }

    public void Enable() {
        Debug.Log("Base Enable");
        InputSystem.onDeviceChange += OnDeviceChange;
    }

    public void Disable() {
        Debug.Log("Base Disable");
        InputSystem.onDeviceChange -= OnDeviceChange;
        var dualSense = DualSenseGamepadHID.FindCurrent();
        dualSense?.Reset();
    }

    // protected void Start() {
    //     Debug.Log("Base Start");
    //     DualSenseGamepadHID dualSense = DualSenseGamepadHID.FindCurrent();
    //     if (dualSense != null) {
    //         NotifyConnection(dualSense);
    //     } else {
    //         NotifyDisconnection();
    //     }
    // }

    // protected void Update() {
    //     UpdateButton();
    // }

    // protected void OnEnable() {
    //     Debug.Log("Base Enable");
    //     InputSystem.onDeviceChange += OnDeviceChange;
    // }

    // protected void OnDisable() {
    //     Debug.Log("Base Disable");
    //     InputSystem.onDeviceChange -= OnDeviceChange;
    //     var dualSense = DualSenseGamepadHID.FindCurrent();
    //     dualSense?.Reset();
    // }

    public void UpdateButton() {
        Cross = DualSense.crossButton;
        Square = DualSense.squareButton;
        Circle = DualSense.circleButton;
        Triangle = DualSense.triangleButton;

        R1 = DualSense.R1;
        R2 = DualSense.R2;
        R3 = DualSense.R3;

        L1 = DualSense.L1;
        L2 = DualSense.L2;
        L3 = DualSense.L3;

        Share = DualSense.shareButton;
        Option = DualSense.optionsButton;
        Touchpad = DualSense.touchpadButton;

        Dpad = DualSense.dpad;
        DpadUp = DualSense.dpad.up;
        DpadLeft = DualSense.dpad.left;
        DpadRight = DualSense.dpad.right;
        DpadDown = DualSense.dpad.down;

        LeftStick = Mathf.Abs(DualSense.leftStick.ReadValue().sqrMagnitude) > 0f;
        RightStick = Mathf.Abs(DualSense.rightStick.ReadValue().sqrMagnitude) > 0F;

        MicMute = DualSense.micMuteButton;
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
        OnConnect(dualSense);
    }

    private void NotifyDisconnection() {
        OnDisconnect();
    }

}
