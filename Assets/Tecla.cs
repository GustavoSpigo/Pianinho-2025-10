using UnityEngine;

public class Tecla : MonoBehaviour
{
    public KeyCode tecla;
    private AudioSource audioSource;

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnMouseUp()
    {
        audioSource.Play();
    }

    void Update()
    {
        if (Input.GetKeyDown(tecla))
        {
            audioSource.Play();
        }
    }
}
