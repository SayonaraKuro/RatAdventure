using UnityEngine;

public class PushObjects : MonoBehaviour
{
    [SerializeField] private CharacterController CC;
    public float pushPower = 4;
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody body = hit.collider.attachedRigidbody;
        if (body == null || body.isKinematic)
            return;
        Vector3 pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);
        Vector3 collissionPoint = hit.point;
        body.AddForceAtPosition(pushDir * pushPower, collissionPoint, ForceMode.Impulse);
    }
}
