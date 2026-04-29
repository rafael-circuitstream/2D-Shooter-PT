using UnityEngine;

public abstract class Weapon : ScriptableObject
{
    [SerializeField] protected float damage;
    [SerializeField] protected AudioClip weaponSound;

    public abstract void Use(Transform weaponTip);

}

