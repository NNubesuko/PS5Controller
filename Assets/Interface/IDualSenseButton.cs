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

}
