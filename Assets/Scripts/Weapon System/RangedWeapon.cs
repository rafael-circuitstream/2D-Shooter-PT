using UnityEngine;

public class RangedWeapon : Weapon
{
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private float fireRate;
    public override void Use()
    {
        Debug.Log("Pew Pew");
    }
}
