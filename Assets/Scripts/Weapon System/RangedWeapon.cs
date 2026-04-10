using UnityEngine;

public class RangedWeapon : Weapon
{
    [SerializeField] private Projectile projectilePrefab;
    [SerializeField] private Transform weaponTip;
    [SerializeField] private float fireRate;
    
    public override void Use()
    {
        GameObject.Instantiate(projectilePrefab, weaponTip.position, weaponTip.rotation);


    }

    public RangedWeapon(Projectile newProjectile, Transform newTip)
    {
        projectilePrefab = newProjectile;
        weaponTip = newTip;
    }
}
