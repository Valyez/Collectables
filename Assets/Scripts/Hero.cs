using UnityEngine;

[RequireComponent(typeof(PotionCollector))]
[RequireComponent(typeof(MovementController))]
public class Hero : MonoBehaviour
{
    private const string MISSING_ITEM = "Предмет отсутствует!";
    private Bag _bag;
    

    private void Awake()
    {
        PotionCollector collector = GetComponent<PotionCollector>();
        _bag = collector.Bag;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (_bag.IsEmpty() == false)
            {
                _bag.GetPotion().Use(gameObject);
                ParticleSystem particleSystem = _bag.gameObject.GetComponentInChildren<ParticleSystem>();
                
                if (particleSystem != null)
                {
                    particleSystem.Play();
                }
            }
            else
            {
                Debug.Log(MISSING_ITEM);
            }
        }
    }

    
}