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
{

    /*
     * Main Body
     */
    public DualSenseGamepadHID DualSense { get; set; }
    public bool IsNull { get; set; }

    /*
     * Button
     */
    public ButtonControl Cross { get; set; }
    public ButtonControl Square { get; set; }
    public ButtonControl Circle { get; set; }
    public ButtonControl Triangle { get; set; }
    public ButtonControl R1 { get; set; }
    public ButtonControl R2 { get; set; }
    public ButtonControl R3 { get; set; }
    public ButtonControl L1 { get; set; }
    public ButtonControl L2 { get; set; }
    public ButtonControl L3 { get; set; }
    public ButtonControl Share { get; set; }
    public ButtonControl Option { get; set; }
    public ButtonControl Touchpad { get; set; }
    public DpadControl Dpad { get; set; }
    public ButtonControl DpadUp { get; set; }
    public ButtonControl DpadLeft { get; set; }
    public ButtonControl DpadRight { get; set; }
    public ButtonControl DpadDown { get; set; }
    public bool LeftStick { get; set; }
    public bool RightStick { get; set; }
    public ButtonControl MicMute { get; set; }

    /*
     * Moter
     */
    public float LeftMoter { get; set; }
    public float RightMoter { get; set; }

    protected void UpdateDualSense() {
        // デフォルトメソッドを使用するために、アップキャストしている
        ((IDualSenseButton)this).Update(DualSense);
        ((IDualSenseMoter)this).Update(DualSense);
    }

}
