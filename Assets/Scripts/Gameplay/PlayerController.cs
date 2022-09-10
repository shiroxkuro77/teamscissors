using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    #region Fields

    private Rigidbody2D rb2D;

    // Movement support
    private Vector2 movementInput;
    [SerializeField]
    private ContactFilter2D movementFilter;
    private List<RaycastHit2D> castCollisions;

    // TODO: change to const
    [SerializeField]
    private float movementSpeed = 3f;
    [SerializeField]
    private float collisionOffset = 0.05f;

    // Physics support
    int numCollisions;

    #endregion

    #region Methods

    void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        castCollisions = new List<RaycastHit2D>();
    }

    void OnMove(InputValue movementValue)
    {
        movementInput = movementValue.Get<Vector2>();
    }

    void FixedUpdate()
    {
        if (movementInput != Vector2.zero)
        {
            numCollisions = rb2D.Cast(
                movementInput,
                movementFilter,
                castCollisions,
                movementSpeed * Time.fixedDeltaTime * collisionOffset
                );

            if (numCollisions == 0)
            {
                rb2D.MovePosition(rb2D.position + movementInput * movementSpeed * Time.fixedDeltaTime);
            }
        }
    }

    #endregion
}
