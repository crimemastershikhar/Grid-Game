using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSystemModel 
{
    public WeaponSystemModel(WeaponSO weaponSO)
    {
        Ammo = weaponSO.ammo;
        ClipSize = weaponSO.clipSize;
        AmmoInClip = ClipSize;
        Damage = weaponSO.damage;
        FireRate = weaponSO.fireRate;
        WeaponSprite = weaponSO.weaponSprite;
        WeaponSlotType = weaponSO.slotType;
        Type = weaponSO.type;
    }

    public int Ammo { get; }
    public int ClipSize { get; }
    public int AmmoInClip { get; set; }
    public int Damage { get; }
    public int FireRate { get; }
    public Sprite WeaponSprite { get; }
    public WeaponSlotType WeaponSlotType { get; set; }
    public WeaponType Type { get; private set; }
}
