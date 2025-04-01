using UnityEngine;

public class FireballPotion : Potion
{
    

    public override void Use(GameObject gameObject)
    {
        AttackBehaviour attackBehaviour = gameObject.GetComponent<AttackBehaviour>();
        
        if (attackBehaviour != null)
        {
            attackBehaviour.Launch(gameObject.transform.rotation);
        }
        
        base.Use(gameObject);
    }
}