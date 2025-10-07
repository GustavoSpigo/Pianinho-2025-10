using UnityEngine;

public class TrocarLoop : MonoBehaviour
{
    [SerializeField] private AudioClip som;
    [SerializeField] private AudioSource loopSource;
    private Animator animator;


    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {

        animator.SetBool("ativo", loopSource.clip == som && loopSource.isPlaying);

    }

    void OnMouseUp()
    {
        if(loopSource.clip == som && loopSource.isPlaying)
        {
            loopSource.Stop();            
            return;
        }

        loopSource.clip = som;
        loopSource.Play();
    }
}
 