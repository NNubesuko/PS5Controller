using UniSense;

public interface IDualSense {

    DualSenseGamepadHID DualSense { get; set; }
    bool IsNull { get; set; }

    void OnConnect(DualSenseGamepadHID dualSense) {
        DualSense = dualSense;
    }

    void OnDisconnect() {
        DualSense = null;
    }

}
