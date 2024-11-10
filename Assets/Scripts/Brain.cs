using UnityEngine;

// AI CAR
public class Brain : MonoBehaviour
{
    public Path path;
    public float minTurnAngle = 1f;
    public float minTargetDistance = 1f;
    Transform target;


    Vehicle vehicle;

    void Start()
    {
        vehicle = GetComponent<Vehicle>();
        target = path.GetClosestPoint(transform.position);
    }


    void Update()
    {
        vehicle.Gas();

        // get turn side
        float angle = Vector3.SignedAngle(transform.forward, target.position - transform.position, Vector3.up);
        if (angle < -minTurnAngle || angle > minTurnAngle)
        {
            float side = Mathf.Sign(angle);
            vehicle.Turn(side);
        }

        // get next checkpoint
        var distance = Vector3.Distance(transform.position, target.position);
        if (distance < minTargetDistance)
        {
            target = path.GetNextPoint(target);
        }
    }
}