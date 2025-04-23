using UnityEngine;

public class WallClimb : MonoBehaviour
{
    //public Transform playerTransform;
    //public float speed = 4;
    //void FixedUpdate()
    //{
    //    if(Input.GetKey(KeyCode.E))
    //    {
    //        playerTransform.Translate(Vector3.up * speed * Time.deltaTime, Space.World);
    //        Debug.Log("CLIMB BITCH");
    //    }
    //}

    public Rigidbody rg;
    public float speed = 10f;

    private void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.E))
        {
            rg.AddForce(Vector3.up * speed * Time.deltaTime, ForceMode.VelocityChange);
            Debug.Log("CLIMB");
        }
    }
}
