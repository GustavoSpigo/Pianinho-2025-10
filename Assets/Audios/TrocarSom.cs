using UnityEngine;

public class TrocarSom : MonoBehaviour
{
    //Mus�ca para vincular nas teclas
    public AudioClip som;
    public KeyCode tecla;
    public AudioSource[] teclas;

    void OnMouseUp()
    {
        AtribuirTeclas();
    }

    void Update()
    {
        if (Input.GetKeyDown(tecla))
        {
            AtribuirTeclas();
        }
    }

    void AtribuirTeclas()
    {
        foreach (AudioSource cadaTecla in teclas)
        {
            cadaTecla.clip = som;
        }
    }
}
