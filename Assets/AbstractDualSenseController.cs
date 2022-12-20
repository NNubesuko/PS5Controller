using UniSense;

public abstract class AbstractDualSenseController {

    public DualSenseGamepadHID DualSense { get; protected set; }

    internal virtual void OnConnect(DualSenseGamepadHID dualSense)
        => DualSense = dualSense;
    
    internal virtual void OnDisconnect() => DualSense = null;

}
