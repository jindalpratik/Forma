using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] Rigidbody2D myRigidBody2D;
    [SerializeField] float flapStrength;
    [SerializeField] float moveSpeed;
    [SerializeField] Animator anim;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRigidBody2D.constraints = RigidbodyConstraints2D.FreezeRotation;
        anim.SetBool("ToRun", false);
    }

    // Update is called once per frame
    void Update()
    {
        // Jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidBody2D.linearVelocity = Vector2.up * flapStrength;
        }

        // Run
        if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("ToRun", true);
            myRigidBody2D.linearVelocity = Vector2.right * moveSpeed;
        }
        else
        {
            anim.SetBool("ToRun", false);
        }

        myRigidBody2D.angularVelocity = 0f;
    }
}
