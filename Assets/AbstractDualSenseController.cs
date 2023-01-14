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
    IDualSenseTouchpadColor,
    IDualSenseTrigger
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
    #region Button
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
    #endregion

    /*
     * Moter
     */
    public void SetMotorSpeeds(float leftMoter, float rightMoter) {
        DualSense?.SetMotorSpeeds(rightMoter, leftMoter);
    }

    /*
     * Trigger
     */
    #region Trigger
    protected DualSenseTriggerState leftTriggerState;
    protected DualSenseTriggerState rightTriggerState;

    public int LeftTriggerEffectType {
        get => (int)leftTriggerState.EffectType;
        set => leftTriggerState.EffectType = ((IDualSenseTrigger)this).SetTriggerEffectType(value);
    }
    public float LeftContinuousForce {
        get => leftTriggerState.Continuous.Force;
        set => leftTriggerState.Continuous.Force = (byte)(value * 255);
    }
    public float LeftContinuousStartPosition {
        get => leftTriggerState.Continuous.StartPosition;
        set => leftTriggerState.Continuous.StartPosition = (byte)(value * 255);
    }
    public float LeftSectionForce {
        get => leftTriggerState.Section.Force;
        set => leftTriggerState.Section.Force = (byte)(value * 255);
    }
    public float LeftSectionStartPosition {
        get => leftTriggerState.Section.StartPosition;
        set => leftTriggerState.Section.StartPosition = (byte)(value * 255);
    }
    public float LeftSectionEndPosition {
        get => leftTriggerState.Section.EndPosition;
        set => leftTriggerState.Section.EndPosition = (byte)(value * 255);
    }
    public float LeftEffectStartPosition {
        get => leftTriggerState.EffectEx.StartPosition;
        set => leftTriggerState.EffectEx.StartPosition = (byte)(value * 255);
    }
    public float LeftEffectBeginForce {
        get => leftTriggerState.EffectEx.BeginForce;
        set => leftTriggerState.EffectEx.BeginForce = (byte)(value * 255);
    }
    public float LeftEffectMiddleForce {
        get => leftTriggerState.EffectEx.MiddleForce;
        set => leftTriggerState.EffectEx.MiddleForce = (byte)(value * 255);
    }
    public float LeftEffectEndForce {
        get => leftTriggerState.EffectEx.EndForce;
        set => leftTriggerState.EffectEx.EndForce = (byte)(value * 255);
    }
    public float LeftEffectFrequency {
        get => leftTriggerState.EffectEx.Frequency;
        set => leftTriggerState.EffectEx.Frequency = (byte)(value * 255);
    }
    public bool LeftEffectKeepEffect {
        get => leftTriggerState.EffectEx.KeepEffect;
        set => leftTriggerState.EffectEx.KeepEffect = value;
    }

    public int RightTriggerEffectType {
        get => (int)rightTriggerState.EffectType;
        set => rightTriggerState.EffectType = ((IDualSenseTrigger)this).SetTriggerEffectType(value);
    }
    public float RightContinuousForce {
        get => rightTriggerState.Continuous.Force;
        set => rightTriggerState.Continuous.Force = (byte)(value * 255);
    }
    public float RightContinuousStartPosition {
        get => rightTriggerState.Section.Force;
        set => rightTriggerState.Section.Force = (byte)(value * 255);
    }
    public float RightSectionForce {
        get => rightTriggerState.Section.Force;
        set => rightTriggerState.Section.Force = (byte)(value * 255);
    }
    public float RightSectionStartPosition {
        get => rightTriggerState.Section.StartPosition;
        set => rightTriggerState.Section.StartPosition = (byte)(value * 255);
    }
    public float RightSectionEndPosition {
        get => rightTriggerState.Section.EndPosition;
        set => rightTriggerState.Section.EndPosition = (byte)(value * 255);
    }
    public float RightEffectStartPosition {
        get => rightTriggerState.EffectEx.StartPosition;
        set => rightTriggerState.EffectEx.StartPosition = (byte)(value * 255);
    }
    public float RightEffectBeginForce {
        get => rightTriggerState.EffectEx.BeginForce;
        set => rightTriggerState.EffectEx.BeginForce = (byte)(value * 255);
    }
    public float RightEffectMiddleForce {
        get => rightTriggerState.EffectEx.MiddleForce;
        set => rightTriggerState.EffectEx.MiddleForce = (byte)(value * 255);
    }
    public float RightEffectEndForce {
        get => rightTriggerState.EffectEx.EndForce;
        set => rightTriggerState.EffectEx.EndForce = (byte)(value * 255);
    }
    public float RightEffectFrequency {
        get => rightTriggerState.EffectEx.Frequency;
        set => rightTriggerState.EffectEx.Frequency = (byte)(value * 255);
    }
    public bool RightEffectKeepEffect {
        get => rightTriggerState.EffectEx.KeepEffect;
        set => rightTriggerState.EffectEx.KeepEffect = value;
    }
    #endregion

    protected void AwakeState() {
        leftTriggerState = new DualSenseTriggerState{
            EffectType = DualSenseTriggerEffectType.ContinuousResistance,
            EffectEx = new DualSenseEffectExProperties(),
            Section = new DualSenseSectionResistanceProperties(),
            Continuous = new DualSenseContinuousResistanceProperties()
        };

        rightTriggerState = new DualSenseTriggerState {
            EffectType = DualSenseTriggerEffectType.ContinuousResistance,
            EffectEx = new DualSenseEffectExProperties(),
            Section = new DualSenseSectionResistanceProperties(),
            Continuous = new DualSenseContinuousResistanceProperties()
        };
    }

    protected void UpdateState() {
        DualSenseGamepadState state = new DualSenseGamepadState{
            LeftTrigger = leftTriggerState,
            RightTrigger = rightTriggerState
        };
        DualSense?.SetGamepadState(state);
    }

}
