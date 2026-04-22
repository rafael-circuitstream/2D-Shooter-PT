using UnityEngine;

public class HealthPickup : Pickup
{
    [SerializeField] private float healthAmount;

    public override void CollectPickup(Player player)
    {
        player.health.IncreaseHealth(healthAmount);
        base.CollectPickup(player);

    }
}
