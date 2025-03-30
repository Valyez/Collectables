using UnityEngine;

public class SpeedPotion : Potion
{
    [SerializeField] private int _speedToAdd;

    public override void Use(Hero hero)
    {
        hero.AddSpeed(_speedToAdd);
        base.Use(hero);
    }
}