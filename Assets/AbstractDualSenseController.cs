using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Controls;
using UniSense;

public abstract class AbstractDualSenseController :
    MonoBehaviour,
    IDualSense,
    IDualSenseButton,
    IDualSenseMoter,
    IDualSenseTouchpadColor
    // IDualSenseTrigger
{

    /*
     * Main Body
     */
    public DualSenseGamepadHID DualSense { get; set; }
    public bool IsNull {
        get => DualSense == null;
        set => value = DualSense == null;
    }

    /*
     * Button
     */
    public ButtonControl Cross {
        get => DualSense.crossButton;
        set => value = DualSense.crossButton;
    }
    public ButtonControl Square {
        get => DualSense.squareButton;
        set => value = DualSense.squareButton;
    }
    public ButtonControl Circle {
        get => DualSense.circleButton;
        set => value = DualSense.circleButton;
    }
    public ButtonControl Triangle {
        get => DualSense.triangleButton;
        set => value = DualSense.triangleButton;
    }
    public ButtonControl L1 {
        get => DualSense.L1;
        set => value = DualSense.L1;
    }
    public ButtonControl L2 {
        get => DualSense.L2;
        set => value = DualSense.L2;
    }
    public ButtonControl L3 {
        get => DualSense.L3;
        set => value = DualSense.L3;
    }
    public ButtonControl R1 {
        get => DualSense.R1;
        set => value = DualSense.R1;
    }
    public ButtonControl R2 {
        get => DualSense.R2;
        set => value = DualSense.R2;
    }
    public ButtonControl R3 {
        get => DualSense.R3;
        set => value = DualSense.R3;
    }
    public ButtonControl Share {
        get => DualSense.shareButton;
        set => value = DualSense.shareButton;
    }
    public ButtonControl Option {
        get => DualSense.optionsButton;
        set => value = DualSense.optionsButton;
    }
    public ButtonControl Touchpad {
        get => DualSense.touchpadButton;
        set => value = DualSense.touchpadButton;
    }
    public DpadControl Dpad {
        get => DualSense.dpad;
        set => value = DualSense.dpad;
    }
    public ButtonControl DpadUp {
        get => DualSense.dpad.up;
        set => value = DualSense.dpad.up;
    }
    public ButtonControl DpadLeft {
        get => DualSense.dpad.left;
        set => value = DualSense.dpad.left;
    }
    public ButtonControl DpadRight {
        get => DualSense.dpad.right;
        set => value = DualSense.dpad.right;
    }
    public ButtonControl DpadDown {
        get => DualSense.dpad.down;
        set => value = DualSense.dpad.down;
    }
    public bool LeftStick {
        get => Mathf.Abs(DualSense.leftStick.ReadValue().sqrMagnitude) > 0f;
        set => value = Mathf.Abs(DualSense.leftStick.ReadValue().sqrMagnitude) > 0f;
    }
    public bool RightStick {
        get => Mathf.Abs(DualSense.rightStick.ReadValue().sqrMagnitude) > 0f;
        set => value = Mathf.Abs(DualSense.rightStick.ReadValue().sqrMagnitude) > 0f;
    }
    public ButtonControl MicMute {
        get => DualSense.micMuteButton;
        set => value = DualSense.micMuteButton;
    }

    /*
     * Moter
     */
    public void SetMotorSpeeds(float leftMoter, float rightMoter) {
        DualSense?.SetMotorSpeeds(rightMoter, leftMoter);
    }

    /*
     * Trigger
     */
    // protected DualSenseTriggerState leftTriggerState;
    // protected DualSenseTriggerState rightTriggerState;

    // public int LeftTriggerEffectType {
    //     get => (int)leftTriggerState.EffectType;
    //     set => leftTriggerState.EffectType = ((IDualSenseTrigger)this).SetTriggerEffectType(value);
    // }
    // public float LeftContinuousForce {
    //     get => leftTriggerState.Continuous.Force;
    //     set => leftTriggerState.Continuous.Force = (byte)(value * 255);
    // }
    // public float LeftContinuousStartPosition { get; set; }
    // public float LeftSectionForce { get; set; }
    // public float LeftSectionStartPosition { get; set; }
    // public float LeftSectionEndPosition { get; set; }
    // public float LeftEffectStartPosition { get; set; }
    // public float LeftEffectBeginForce { get; set; }
    // public float LeftEffectMiddleForce { get; set; }
    // public float LeftEffectEndForce { get; set; }
    // public float LeftEffectFrequency { get; set; }
    // public bool LeftEffectKeepEffect { get; set; }

    // public int RightTriggerEffectType { get; set; }
    // public float RightContinuousForce { get; set; }
    // public float RightContinuousStartPosition { get; set; }
    // public float RightSectionForce { get; set; }
    // public float RightSectionStartPosition { get; set; }
    // public float RightSectionEndPosition { get; set; }
    // public float RightEffectStartPosition { get; set; }
    // public float RightEffectBeginForce { get; set; }
    // public float RightEffectMiddleForce { get; set; }
    // public float RightEffectEndForce { get; set; }
    // public float RightEffectFrequency { get; set; }
    // public bool RightEffectKeepEffect { get; set; }

}
