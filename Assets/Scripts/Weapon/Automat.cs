using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Automat : Weapon
{

    protected override void Shoot()
    {
        if (!IsDelaying)
        {
            Instantiate(bullet, spawnPoint.position, Quaternion.identity);
            IsDelaying = true;
        }
    }

    protected override void Reload()
    {
        if (CurrentMagazine < DefaultMagazine)
        {
            //Перезарядка через анимацию
        }
    }

    protected override void AddMagazine()
    {
        int difference = DefaultMagazine - CurrentMagazine;
        if (difference > Amount)
        {
            CurrentMagazine += Amount;
            Amount = 0;
        }
        else
        {
            CurrentMagazine += difference;
            Amount -= difference;
        }
    }

    
}
