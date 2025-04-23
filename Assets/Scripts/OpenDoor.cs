using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public Animator doorAnimator;
    public MeshRenderer doorKey;
    public Animator chestAnimator;

    private void Start()
    {
        Cursor.visible = false;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            doorAnimator.SetBool("doorOpen", true);
        }

        if (Input.GetKey(KeyCode.T))
        {
            doorKey.enabled = false;
        }

        if (Input.GetKey(KeyCode.Y))
        {
            chestAnimator.SetBool("openChest", true);
        }
    }
}
