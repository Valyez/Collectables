using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public bool IsFree => _potion is null;
    public Potion _potion;

    

    public void Occupy(Potion potion)
    {
        _potion = potion;
    }
}