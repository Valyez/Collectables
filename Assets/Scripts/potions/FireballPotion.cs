using UnityEngine;

public class FireballPotion : Potion
{
    [SerializeField] private Projectile _fireballProjectile;

    public override void Use(Hero hero)
    {
        Transform heroTransform = hero.transform;
        Instantiate(_fireballProjectile, heroTransform.position, heroTransform.rotation);
        base.Use(hero);
    }
}