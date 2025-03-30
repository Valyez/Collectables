using UnityEngine;

public class MovementController : MonoBehaviour
{
    private const string HORIZONTAL_AXIS_NAME = "Horizontal";
    private const string VERTICAL_AXIS_NAME = "Vertical";
    private const float MIN_DISTANCE = 0.005f;
    private const float MAX_SPEED = 20f;
    private const float MIN_SPEED = 10f;
    private const float SPEED_DECREASE_STEP = 1f;

    [SerializeField] private float _speed;


    private void Update()
    {
        DecreaseSpeed();
        float horizontal = Input.GetAxisRaw(HORIZONTAL_AXIS_NAME);
        float vertical = Input.GetAxisRaw(VERTICAL_AXIS_NAME);

        Vector3 inputVector =
            new Vector3(horizontal * (_speed * Time.deltaTime), 0, vertical * (_speed * Time.deltaTime));

        if (inputVector.magnitude > MIN_DISTANCE)
        {
            Move(inputVector);
        }
    }

    private void DecreaseSpeed()
    {
        if (_speed > MIN_SPEED)
        {
            _speed -= SPEED_DECREASE_STEP * Time.deltaTime;
        }
    }

    private void Move(Vector3 vector)
    {
        RotateToTarget(vector);
        MoveToTarget(vector);
    }

    private void RotateToTarget(Vector3 vectorToTarget)
    {
        transform.rotation = Quaternion.LookRotation(vectorToTarget);
    }

    private void MoveToTarget(Vector3 vector)
    {
        transform.position += vector.normalized * (_speed * Time.deltaTime);
    }

    public void AddSpeed(in float addedSpeed)
    {
        _speed += addedSpeed;

        if (_speed > MAX_SPEED)
        {
            _speed = MAX_SPEED;
        }
    }
}