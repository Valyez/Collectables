using UnityEngine;

public class AttackBehaviour : MonoBehaviour
{
    [SerializeField] private Projectile _fireballProjectile;


    public void Launch(Quaternion transformRotation)
    {
        Instantiate(_fireballProjectile, gameObject.transform.position,transformRotation);
    }
}