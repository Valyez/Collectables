using UnityEngine;

public class SpeedPotion : Potion
{
    [SerializeField] private int _speedToAdd;

    public override void Use(GameObject gameObject)
    {
        MovementController movementController = gameObject.GetComponent<MovementController>();
        
        if (movementController != null)
        {
            movementController.AddSpeed(_speedToAdd);
        }
        
        base.Use(gameObject);
    }
}