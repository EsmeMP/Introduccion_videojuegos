using UnityEngine;
using TMPro;

public class ControladorScore : MonoBehaviour
{
    public static ControladorScore instancia;

    public TMP_Text textoScore;

    private int cerezas = 0;

    void Awake()
    {
        instancia = this;
    }

    public void SumarCereza()
    {
        cerezas++;
        textoScore.text = "Cerezas: " + cerezas;
    }
}