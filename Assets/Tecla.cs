using System.Collections;
using UnityEngine;

public class Tecla : MonoBehaviour
{
    public KeyCode tecla;
    private AudioSource audioSource;
    private float posicaoInicialY;
    [SerializeField] private float posicaoFinalY = -0.1f;
    private Coroutine animacaoCoroutine;

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
        posicaoInicialY = transform.position.y;
    }

    void abaixaTecla()
    {
        if (animacaoCoroutine != null)
        {
            StopCoroutine(animacaoCoroutine);
        }
        transform.position = new Vector3(
            transform.position.x,
            transform.position.y + posicaoFinalY,
            transform.position.z
        );
    }
    void OnMouseDown()
    {
        audioSource.Play();
        abaixaTecla();        
    }

    void OnMouseUp()
    {
        animacaoCoroutine = StartCoroutine(VoltarPosicaoInicial());
    }

    void Update()
    {
        if (Input.GetKeyDown(tecla))
        {
            audioSource.Play();
            abaixaTecla();
        }
        if (Input.GetKeyUp(tecla))
        {
            animacaoCoroutine = StartCoroutine(VoltarPosicaoInicial());
        }
    }

    private IEnumerator VoltarPosicaoInicial()
    {
        float tempoDecorrido = 0f;

        while (tempoDecorrido < 1f)
        {
            tempoDecorrido += Time.deltaTime;
            transform.position = Vector3.Lerp(
                new Vector3(transform.position.x, transform.position.y, transform.position.z),
                new Vector3(transform.position.x, posicaoInicialY, transform.position.z),
                tempoDecorrido / 1f
            );
            
            yield return null;
        }

        animacaoCoroutine = null;
        transform.position = new Vector3(transform.position.x, posicaoInicialY, transform.position.z);
    }
}
