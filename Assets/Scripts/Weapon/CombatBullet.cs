using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatBullet : Bullet
{
    private void Start()
    {
        Push();
    }
    protected override void Push()
    {
        Physic.AddForce(transform.forward * Speed * Time.deltaTime);
    }
    

    
}
