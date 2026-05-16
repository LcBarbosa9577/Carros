using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private float speed = 50f;
    private float turnSpeed = 100f;

    private Vector2 moveInput;

    public void OnMove(InputValue input)
    {
        moveInput = input.Get<Vector2>();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(Vector3.forward * moveInput.y * speed * Time.deltaTime);

        transform.Rotate(Vector3.up * moveInput.x * turnSpeed * Time.deltaTime);

    }
}
