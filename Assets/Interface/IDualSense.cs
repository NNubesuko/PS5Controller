using UniSense;

public interface IDualSense {

    DualSenseGamepadHID DualSense { get; set; }
    bool IsNull { get; set; }

    void OnConnect(DualSenseGamepadHID dualSense) {
        DualSense = dualSense;
        IsNull = false;
    }

    void OnDisconnect() {
        DualSense = null;
        IsNull = true;
    }

}
