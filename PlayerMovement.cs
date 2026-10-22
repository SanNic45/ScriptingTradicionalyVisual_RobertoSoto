using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Variable pública para ajustar la velocidad desde el Inspector de Unity
    public float speed = 5f;
    
    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        // Obtenemos el componente Rigidbody2D del jugador al iniciar
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Detectamos las teclas presionadas (Flechas o WASD)
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        // Aplicamos el movimiento al Rigidbody2D
        // Usamos .normalized para que no se mueva más rápido en diagonal
        rb.linearVelocity = movement.normalized * speed;
    }
}