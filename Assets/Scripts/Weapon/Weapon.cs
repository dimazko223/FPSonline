using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField]private int amount;
    [SerializeField]private int defaultMagazine;
    private int _currentMagazine;
    [SerializeField]private float shootDelay;
    [SerializeField] protected GameObject bullet;
    [SerializeField] protected Transform spawnPoint;
    protected AnimatorController AnimatorController;
    private bool _isDelaying;
    
    protected int Amount
    {
        get => amount;
        set => amount = value;
    }
    protected int CurrentMagazine
    {
        get => _currentMagazine;
        set => _currentMagazine = value;
    }
    protected int DefaultMagazine
    {
        get => defaultMagazine;
        set => defaultMagazine = value;
    }
    protected float ShootDelay
    {
        get => shootDelay;
        set => shootDelay = value;
    }
    
    protected bool IsDelaying
    {
        get => _isDelaying;
        set
        {
            _isDelaying = value;
            if (_isDelaying)
            {
                StartCoroutine(DelayWaiting());
            }
        }
    }

    protected abstract void Shoot();
    protected abstract void Reload();
    protected abstract void AddMagazine();

    private IEnumerator DelayWaiting()
    {
       yield return new WaitForSeconds(ShootDelay);
    }
}
