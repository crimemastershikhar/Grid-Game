using UnityEngine;
using TMPro;

public class WeaponSystemView : MonoBehaviour
{
    public Sprite SecondaryWeaponSprite;
    public TextMeshProUGUI SecondaryWeaponAmmo;
    public Sprite PrimaryWeaponFirstSprite;
    public TextMeshProUGUI PrimaryWeaponFirstAmmo;
    public Sprite PrimaryWeaponSecondSprite;
    public TextMeshProUGUI PrimaryyWeaponSecondAmmo;

    public void WeaponStatus(WeaponSystemController weaponSelect)
    {
        if (weaponSelect.wsModel.WeaponSlotType == WeaponSlotType.SecondaryWeapon)
        {
            SecondaryWeaponSprite = weaponSelect.wsModel.WeaponSprite;
        }
        else if (weaponSelect.wsModel.WeaponSlotType == WeaponSlotType.PrimaryWeaponFirst)
        {
            PrimaryWeaponFirstSprite = weaponSelect.wsModel.WeaponSprite;
        }
        else if (weaponSelect.wsModel.WeaponSlotType == WeaponSlotType.PrimaryWeaponSecond)
        {
            PrimaryWeaponSecondSprite = weaponSelect.wsModel.WeaponSprite;
        }
    }

    private void AmmoStatus(WeaponSystemController weaponSelect)
    {
        if(weaponSelect.wsModel.WeaponSlotType == WeaponSlotType.SecondaryWeapon)
        {
            SecondaryWeaponAmmo.text = weaponSelect.wsModel.AmmoInClip.ToString() + " / " + weaponSelect.wsModel.Ammo.ToString();
        }
        else if (weaponSelect.wsModel.WeaponSlotType == WeaponSlotType.PrimaryWeaponFirst)
        {
            PrimaryWeaponFirstAmmo.text = weaponSelect.wsModel.AmmoInClip.ToString() + " / " + weaponSelect.wsModel.Ammo.ToString();
        }
        else if (weaponSelect.wsModel.WeaponSlotType == WeaponSlotType.PrimaryWeaponSecond)
        {
            PrimaryyWeaponSecondAmmo.text = weaponSelect.wsModel.AmmoInClip.ToString() + " / " + weaponSelect.wsModel.Ammo.ToString();
        }
    }
}
