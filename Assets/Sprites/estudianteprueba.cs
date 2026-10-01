using UnityEngine;

public class estudianteprueba : MonoBehaviour
{
    public float velocidad = 5f;
    private Rigidbody2D rb;
    private Vector2 movimiento;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Lee las teclas (flechas o WASD)
        movimiento.x = Input.GetAxisRaw("Horizontal");
        movimiento.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        // Mueve al personaje
        rb.MovePosition(rb.position + movimiento * velocidad * Time.fixedDeltaTime);
    }
}