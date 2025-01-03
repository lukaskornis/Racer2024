using UnityEngine;

public class Vehicle : MonoBehaviour
{
    public float acceleration;
    public float deceleration;
    public float maxSpeed;
    public float maxReverseSpeed;
    public float speed;
    public float turnSpeed;
    public float speedRatio;
    public AnimationCurve enginePitchCurve;

    public AudioSource engineSound;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Gas()
    {
        speed += acceleration * Time.deltaTime;
        if (speed > maxSpeed) speed = maxSpeed;
    }

    public void Brake()
    {

    }

    void Update()
    {
        speedRatio = speed / maxSpeed;
        engineSound.pitch = enginePitchCurve.Evaluate(speedRatio);

        // friction
        speed *= deceleration;

        // gas
        var y = rb.velocity.y;
        rb.velocity = transform.forward * speed;
        rb.velocity = new Vector3( rb.velocity.x, y, rb.velocity.z );
    }

    public void Turn(float side)
    {
        rb.angularVelocity = new Vector3(0,side * turnSpeed * Mathf.Deg2Rad,0);
    }
}