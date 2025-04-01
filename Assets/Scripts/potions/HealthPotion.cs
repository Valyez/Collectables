using UnityEngine;

public class HealthPotion : Potion
{
    [SerializeField] private int _healthToAdd;

    public override void Use(GameObject gameObject)
    {
        HealthBehaviour healthBehaviour = gameObject.GetComponent<HealthBehaviour>();
        
        if (healthBehaviour != null)
        {
            healthBehaviour.AddHealth(_healthToAdd);
        }
        
        base.Use(gameObject);
    }
}