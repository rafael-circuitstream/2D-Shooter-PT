using UnityEngine;

public abstract class Weapon
{
    [SerializeField] private float damage;

    public abstract void Use();

}

