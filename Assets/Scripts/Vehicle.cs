using UnityEngine;

public class Vehicle : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    public AudioSource engineSound;

    public void Gas()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    public void Brake()
    {
        transform.position -= transform.forward * speed * Time.deltaTime;
    }

    public void Turn(float side)
    {
        transform.Rotate(0,side * turnSpeed * Time.deltaTime,0);
    }
}