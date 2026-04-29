using UnityEngine;

[CreateAssetMenu(menuName = "New Weapon")]
public class RangedWeapon : Weapon
{
    [SerializeField] protected Projectile projectilePrefab;

    [SerializeField] protected float fireRate;

    private AudioManager savedAudioManager;

    public override void Use(Transform weaponTip)
    {
        if(savedAudioManager == null)
        {
            savedAudioManager = FindAnyObjectByType<AudioManager>();
        }

        savedAudioManager.PlayShootingSound(weaponSound);

        Projectile tempProjectile = GameObject.Instantiate(projectilePrefab, weaponTip.position, weaponTip.rotation);
        tempProjectile.damage = damage;

    }

    public float GetFireRate()
    {
        return fireRate;
    }

}
