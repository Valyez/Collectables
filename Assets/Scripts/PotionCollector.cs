using UnityEngine;

public class PotionCollector : MonoBehaviour
{
    private Bag _bag;

    public Bag Bag => _bag;

    private void Awake()
    {
        Bag bag = gameObject.GetComponentInChildren<Bag>();
        
        if (bag != null)
        {
            _bag = bag;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Potion potion = other.gameObject.GetComponent<Potion>();
        
        if (potion != null)
        {
            if (_bag.IsEmpty())
            {
                _bag.AddPotion(potion);
                potion.Collect();
            }
            else
            {
                Debug.Log("Сумка полная, нельзя подобрать предмет!");
            }
        }
    }
}