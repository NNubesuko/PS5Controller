using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniSense;

public interface IDualSenseTrigger {

    int LeftTriggerEffectType { get; set; }
    float LeftContinuousForce { get; set; }
    float LeftContinuousStartPosition { get; set; }
    float LeftSectionForce { get; set; }
    float LeftSectionStartPosition { get; set; }
    float LeftSectionEndPosition { get; set; }
    float LeftEffectStartPosition { get; set; }
    float LeftEffectBeginForce { get; set; }
    float LeftEffectMiddleForce { get; set; }
    float LeftEffectEndForce { get; set; }
    float LeftEffectFrequency { get; set; }
    bool LeftEffectKeepEffect { get; set; }

    int RightTriggerEffectType { get; set; }
    float RightContinuousForce { get; set; }
    float RightContinuousStartPosition { get; set; }
    float RightSectionForce { get; set; }
    float RightSectionStartPosition { get; set; }
    float RightSectionEndPosition { get; set; }
    float RightEffectStartPosition { get; set; }
    float RightEffectBeginForce { get; set; }
    float RightEffectMiddleForce { get; set; }
    float RightEffectEndForce { get; set; }
    float RightEffectFrequency { get; set; }
    bool RightEffectKeepEffect { get; set; }

    DualSenseTriggerEffectType SetTriggerEffectType(int index) {
        if (index == 0) return DualSenseTriggerEffectType.ContinuousResistance;
        if (index == 1) return DualSenseTriggerEffectType.SectionResistance;
        if (index == 2) return DualSenseTriggerEffectType.EffectEx;

        return DualSenseTriggerEffectType.NoResistance;
    }

}
