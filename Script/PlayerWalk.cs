using UnityEngine;
public class PlayerWalk : MonoBehaviour
{
    public float speed = 10f;
    public float dodgeRange = 3f;
    public float dodgeSpeed = 2f;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal"); 
        float yMove = Input.GetAxisRaw("Vertical");
        if(Input.GetButton("Dodge")) rb.velocity = new Vector2(xMove, yMove) * speed * dodgeSpeed;
        else rb.velocity = new Vector2(xMove, yMove) * speed;
    }

    
}
