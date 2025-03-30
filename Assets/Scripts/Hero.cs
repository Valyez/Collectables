using UnityEngine;

[RequireComponent(typeof(PotionCollector))]
[RequireComponent(typeof(MovementController))]
public class Hero : MonoBehaviour
{
    private const string MISSING_ITEM = "Предмет отсутствует!";

    private Bag _bag;
    private MovementController _movementController;
    private int _health;

    private void Awake()
    {
        PotionCollector collector = GetComponent<PotionCollector>();
        _bag = collector.Bag;
        _movementController = GetComponent<MovementController>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (_bag.isEmpty() == false)
            {
                _bag.getPotion().Use(this);
            }
            else
            {
                Debug.Log(MISSING_ITEM);
            }
        }
    }

    public void AddHealth(int addedHealth)
    {
        if (addedHealth > 0)
        {
            _health += addedHealth;
            Debug.Log(_health);
        }
    }

    public void AddSpeed(float addedSpeed)
    {
        if (addedSpeed > 0)
        {
            _movementController.AddSpeed(addedSpeed);
        }
    }
}