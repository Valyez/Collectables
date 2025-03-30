using UnityEngine;

public class PotionCollector : MonoBehaviour
{
    public Bag _bag;

    public Bag Bag => _bag;

    private void Awake()
    {
        _bag = gameObject.GetComponentInChildren(typeof(Bag)) as Bag;
    }

    private void OnTriggerEnter(Collider other)
     {
         Potion potion = other.gameObject.GetComponent<Potion>();
         if (potion != null )
         {
             if (_bag.isEmpty())
             {

                 _bag.AddPotion(potion);
             }
             else
             {
                 Debug.Log("Сумка полная, нельзя подобрать предмет!");
             }
         }
     }
}