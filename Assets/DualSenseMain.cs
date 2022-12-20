using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DualSenseMain : AbstractDualSenseController {

    public bool dpadUp { get; private set; }

    private void Update() {
        if (DualSense == null) return;

        dpadUp = DualSense.dpad.up.isPressed;
    }

}
