using UnityEngine;

public class HealthPotion : Potion
{
    [SerializeField] private int _healthToAdd;

    public override void Use(Hero hero)
    {
        hero.AddHealth(_healthToAdd);
        base.Use(hero);
    }
}