using UnityEngine;
using UniSense;
using UnityEngine.InputSystem.Controls;

public interface IDualSenseButton {

    ButtonControl Cross { get; set; }
    ButtonControl Square { get; set; }
    ButtonControl Circle { get; set; }
    ButtonControl Triangle { get; set; }

    ButtonControl R1 { get; set; }
    ButtonControl R2 { get; set; }
    ButtonControl R3 { get; set; }

    ButtonControl L1 { get; set; }
    ButtonControl L2 { get; set; }
    ButtonControl L3 { get; set; }

    ButtonControl Share { get; set; }
    ButtonControl Option { get; set; }
    ButtonControl Touchpad { get; set; }

    DpadControl Dpad { get; set; }
    ButtonControl DpadUp { get; set; }
    ButtonControl DpadLeft { get; set; }
    ButtonControl DpadRight { get; set; }
    ButtonControl DpadDown { get; set; }

    bool LeftStick { get; set; }
    bool RightStick { get; set; }

    ButtonControl MicMute { get; set; }

    void Update(DualSenseGamepadHID dualSense) {
        Cross = dualSense.crossButton;
        Square = dualSense.squareButton;
        Circle = dualSense.circleButton;
        Triangle = dualSense.triangleButton;

        R1 = dualSense.R1;
        R2 = dualSense.R2;
        R3 = dualSense.R3;

        L1 = dualSense.L1;
        L2 = dualSense.L2;
        L3 = dualSense.L3;

        Share = dualSense.shareButton;
        Option = dualSense.optionsButton;
        Touchpad = dualSense.touchpadButton;

        Dpad = dualSense.dpad;
        DpadUp = dualSense.dpad.up;
        DpadLeft = dualSense.dpad.left;
        DpadRight = dualSense.dpad.right;
        DpadDown = dualSense.dpad.down;

        LeftStick = Mathf.Abs(dualSense.leftStick.ReadValue().sqrMagnitude) > 0f;
        RightStick = Mathf.Abs(dualSense.rightStick.ReadValue().sqrMagnitude) > 0F;

        MicMute = dualSense.micMuteButton;
    }

}
