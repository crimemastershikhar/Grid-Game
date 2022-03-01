using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSystemController
{
    public WeaponSystemView wsView { get; }
    public WeaponSystemModel wsModel { get; }

    public WeaponSystemController(WeaponSystemView weaponPrefab, WeaponSystemModel weaponSystemModel)
    {
        wsView = GameObject.Instantiate(weaponPrefab);
        wsModel = weaponSystemModel;
    }

    public void Shoot()
    {
        if(wsModel.AmmoInClip > 0)
        {
            wsModel.AmmoInClip--;
            //Firing pseudo code
        }
    }
}
