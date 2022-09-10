using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Fields

    [SerializeField]
    private float movementSpeed;

    // For base movement
    private Rigidbody2D rb2D;
    private float horizontal;
    private float vertical;
    private Vector2 velocityVector;

    #endregion

    #region Methods

    void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        if (horizontal != 0)
        {
            velocityVector.x = movementSpeed * horizontal;
            velocityVector.y = 0;
        }
        else if (vertical != 0)
        {
            velocityVector.x = 0;
            velocityVector.y = movementSpeed * vertical;
        }
        else
        {
            velocityVector = Vector2.zero;
        }

        rb2D.velocity = velocityVector;
    }

    #endregion
}
