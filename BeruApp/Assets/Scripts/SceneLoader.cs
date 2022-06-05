using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private Canvas canvas;
    [SerializeField] private Animator canvasAnimator;
    [SerializeField] private float animationTime;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        if (canvasAnimator == null) { return; }
        canvasAnimator = canvas.GetComponent<Animator>();
    }

    IEnumerator TransitionToScene(int index)
    {
        canvasAnimator.Play("FadeIn");

        yield return new WaitForSeconds(animationTime);

        SceneManager.LoadScene(index);

        canvasAnimator.Play("FadeOut");
    }

    public void LoadScene(int index)
    {
        StartCoroutine(TransitionToScene(index));
    }
    public void LoadNextScene()
    {
        StartCoroutine(TransitionToScene(SceneManager.GetActiveScene().buildIndex + 1));
    }
}
