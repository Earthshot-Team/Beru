using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // VARIABLES
    [SerializeField] private Canvas canvas;
    [SerializeField] private Animator canvasAnimator;
    [SerializeField] private float animationTime;

    // METHODS
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        if (canvasAnimator == null) { return; }
        canvasAnimator = canvas.GetComponent<Animator>();
    }

    IEnumerator Co_TransitionToScene(int index)
    {
        canvasAnimator.Play("FadeIn");

        yield return new WaitForSeconds(animationTime);

        SceneManager.LoadScene(index);

        canvasAnimator.Play("FadeOut");
    }
    void TransitionToScene(int index)
    {
        StartCoroutine(Co_TransitionToScene(index));
    }

    public void LoadSceneWithIndex(int index)
    {
        TransitionToScene(index);
    }
    public void LoadNextScene()
    {
        TransitionToScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
