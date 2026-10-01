using UnityEngine;

public class Cereza : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.CompareTag("Player"))
        {
            ControladorScore.instancia.SumarCereza();
            Destroy(gameObject);
        }
    }
}