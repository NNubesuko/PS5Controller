using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniSense;

public abstract class AbstractDualSenseController {

    protected DualSenseGamepadHID DualSense { get; private set; }

    protected void OnConnect(DualSenseGamepadHID dualSense) {
        DualSense = dualSense;
    }

    protected void OnDisconnect() {
        DualSense = null;
    }

}
