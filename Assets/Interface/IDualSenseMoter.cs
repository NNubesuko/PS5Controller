using UniSense;

public interface IDualSenseMoter {

    float LeftMoter { get; set; }
    float RightMoter { get; set; }

    void Update(DualSenseGamepadHID dualSense) {
        dualSense?.SetMotorSpeeds(LeftMoter, RightMoter);
    }

}
