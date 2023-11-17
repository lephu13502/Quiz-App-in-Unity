using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashToGame : MonoBehaviour
{
    [SerializeField] private GameObject bgm;
    [SerializeField] private GameObject splashWhite;
    [SerializeField] private GameObject splashText;

    private void Start()
    {
        StartCoroutine(SplashEnd());
    }

    IEnumerator SplashEnd()
    {
        yield return new WaitForSeconds(4);
        bgm.SetActive(true);
        yield return new WaitForSeconds(1);
        splashText.SetActive(false);
        splashWhite.SetActive(false);
    }
}
