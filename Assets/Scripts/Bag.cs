using UnityEngine;

public class Bag : MonoBehaviour
{
    private Potion _potion;

    public bool isEmpty()
    {
        return _potion == null;
    }

    public void AddPotion(Potion potion)
    {
        _potion = potion;
        Animator animator = _potion.gameObject.GetComponent<Animator>();
        animator.Play("Stop");
        Collider potionCollider = _potion.gameObject.GetComponent<Collider>();
        potionCollider.enabled = false;
        potion.transform.SetParent(transform);
    }

    public Potion getPotion()
    {
        return _potion;
    }
}