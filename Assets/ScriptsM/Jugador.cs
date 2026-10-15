using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jugador : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 9f;

    private Rigidbody2D rb2D;
    private float move;

    public Transform groundCheck;
    public float groundRadius = 0.2f;
    public LayerMask groundLayer;

    private bool isGrounded;

    private int coins;
    public TMP_Text textCoins;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // MOVIMIENTO DERECHA E IZQUIERDA
        move = Input.GetAxisRaw("Horizontal");

        rb2D.linearVelocity = new Vector2(
            move * speed,
            rb2D.linearVelocity.y
        );

        // GIRAR PERSONAJE SIN CAMBIAR SU TAMAÑO
        if (move != 0)
        {
            Vector3 escala = transform.localScale;
            escala.x = Mathf.Abs(escala.x) * Mathf.Sign(move);
            transform.localScale = escala;
        }

        // SALTO CON ESPACIO
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb2D.linearVelocity = new Vector2(
                rb2D.linearVelocity.x,
                jumpForce
            );
        }
    }

    void FixedUpdate()
    {
        // COMPROBAR SI ESTÁ TOCANDO EL SUELO
        isGrounded = Physics2D.OverlapCircle(
            groundCheck.position,
            groundRadius,
            groundLayer
        );
    }

    // RECOGER MONEDAS
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("coin"))
        {
            Destroy(collision.gameObject);
            coins++;
            textCoins.text=coins.ToString();

        }

        if (collision.transform.CompareTag("Spikes"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
}