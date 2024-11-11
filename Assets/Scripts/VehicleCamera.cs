using UnityEngine;

[ExecuteAlways]
public class VehicleCamera : MonoBehaviour
{
    [Range(0f,1f)]public float posStep;
    public Vehicle target;
    public Camera cam;


    void LateUpdate()
    {
        cam.fieldOfView = Mathf.Lerp(50f, 100f, target.speedRatio);
        transform.position = Vector3.Lerp(transform.position,target.transform.position,posStep);
        transform.forward = target.transform.forward;
    }
}