using System;
using UnityEngine;

[ CreateAssetMenu(fileName = "Weapons", menuName = "WeaponInventory/List/NewWeapon")]
public class WeaponSO : ScriptableObject
{
    public int ammo;
    public int clipSize;
    public int damage;
    public int fireRate;
    public Sprite weaponSprite;
    public WeaponSlotType slotType;
    public WeaponType type;
}
