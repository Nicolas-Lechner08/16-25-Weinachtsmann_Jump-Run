using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rB;
    public string rightKey = "D";
    bool isTouching_ground = false;
    public int jump_force = 300;

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rB.AddForce(Vector2.right * 7);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rB.AddForce(Vector2.left * 7);
        }
        if (Input.GetKeyDown(KeyCode.Space) && isTouching_ground)
        {
            rB.AddForceY(jump_force);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {

            foreach (ContactPoint2D contact in collision.contacts)
            {
                if (contact.normal.y > 0.5f) 
                {
                    isTouching_ground = true;
                }
            }
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isTouching_ground = false;
        }
    }
}
