using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAnimate
{
    void ResetParameters();
    void LoadAnimator();
    void SetParameter(string name, bool value);
    void SetParameter(string name, int value);
    void SetParameter(string name, float value);
}
