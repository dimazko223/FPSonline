using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
    private Rigidbody _physic;
    [SerializeField] private float speed;

    protected Rigidbody Physic
    {
        get => _physic;
        set => _physic = value;
    }
    protected float Speed
    {
        get => speed;
        set => speed = value;
    }
    private void Start()
    {
        Physic = GetComponent<Rigidbody>();
    }

    protected abstract void Push();

    protected virtual void Explosion()
    {
        
    }
    
}
