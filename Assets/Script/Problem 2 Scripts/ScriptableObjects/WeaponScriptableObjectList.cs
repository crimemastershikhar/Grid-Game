using UnityEngine;


namespace TankSO
{
    [CreateAssetMenu(fileName = "WeaponScriptableObjectList", menuName = "WeaponInventory/List/CreateNewWeapon")]
    public class ScriptableObjectList : ScriptableObject
    {
        public WeaponSO[] weapon;
    }
}