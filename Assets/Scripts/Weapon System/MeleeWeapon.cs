using UnityEngine;

public class MeleeWeapon : Weapon
{
    [SerializeField] private float range;

    public override void Use(Transform weaponTip)
    {
        Debug.Log("Slash");
        PlayAnimation();
    }

    private void PlayAnimation()
    {

    }
}
