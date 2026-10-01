using UnityEngine;

public class MovimientoHelado : MonoBehaviour
{
    public float velocidad = 3f;

    // 0 = derecha, 1 = abajo, 2 = arriba, 3 = izquierda
    public Sprite[] sprites;

    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private Vector2 direccion;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        // Solo una dirección a la vez
        if (x != 0) y = 0;

        direccion = new Vector2(x, y);

        // Cambiar sprite según la dirección
        if (x > 0) sr.sprite = sprites[0];
        else if (y < 0) sr.sprite = sprites[1];
        else if (y > 0) sr.sprite = sprites[2];
        else if (x < 0) sr.sprite = sprites[3];
    }

    void FixedUpdate()
    {
        rb.linearVelocity = direccion * velocidad;
    }
}