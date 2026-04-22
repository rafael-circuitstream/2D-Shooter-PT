using UnityEngine;

[CreateAssetMenu(menuName = "New Weapon")]
public class RangedWeapon : Weapon
{
    [SerializeField] protected Projectile projectilePrefab;

    [SerializeField] protected float fireRate;
    
    public override void Use(Transform weaponTip)
    {
        Projectile tempProjectile = GameObject.Instantiate(projectilePrefab, weaponTip.position, weaponTip.rotation);
        tempProjectile.damage = damage;

    }

}
