using UnityEngine;

public class FireballPotion : Potion
{

    public override void Use(Hero hero)
    {
        Quaternion heroTransformRotation = hero.transform.rotation;
        Destroy(gameObject);
    }
}