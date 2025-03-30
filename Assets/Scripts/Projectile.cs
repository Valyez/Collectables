using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float _projectileSpeed;
    [SerializeField] private float _timeToLive;

    private float _timer;

    private void Update()
    {
        _timer += Time.deltaTime;
        
        if (_timer < _timeToLive)
        {
            transform.position += transform.forward * (_projectileSpeed * Time.deltaTime);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}