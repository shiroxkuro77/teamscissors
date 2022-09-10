using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float bulletSpeed = 3f;

    public enum Direction
    {
        Up, Down, Left, Right
    }
    public Direction direction;
    private Rigidbody2D bulletRb;

    // Start is called before the first frame update
    void Start()
    {
        bulletRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (direction)
        {
            case Direction.Up:
                bulletRb.velocity = new Vector2(0, bulletSpeed);
                break;
            case Direction.Down:
                bulletRb.velocity = new Vector2(0, -bulletSpeed);
                break;
            case Direction.Left:
                bulletRb.velocity = new Vector2(-bulletSpeed, 0);
                break;
            case Direction.Right:
                bulletRb.velocity = new Vector2(bulletSpeed, 0);
                break;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
