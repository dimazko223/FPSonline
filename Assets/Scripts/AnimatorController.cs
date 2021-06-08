using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour,IAnimate
{
    private Animator _animator;
    public void ResetParameters()
    {
        _animator.Rebind();
    }

    public void LoadAnimator()
    {
        _animator = GetComponent<Animator>();
    }

    public void SetParameter(string name, bool value)
    {
        _animator.SetBool(name,value);
    }

    public void SetParameter(string name, int value)
    {
        _animator.SetInteger(name,value);
    }

    public void SetParameter(string name, float value)
    {
        _animator.SetFloat(name,value);
    }
}
