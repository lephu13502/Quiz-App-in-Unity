using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class QuestionDisplay : MonoBehaviour
{
    [SerializeField] private GameObject screenQuestion;
    [SerializeField] private GameObject answerA;
    [SerializeField] private GameObject answerB;
    [SerializeField] private GameObject answerC;
    [SerializeField] private GameObject answerD;
    public static string newQuestion;
    public static string newA;
    public static string newB;
    public static string newC;
    public static string newD;
    public static bool pleaseUpdate = false;

    private void Update()
    {
        if (pleaseUpdate == false)
        {
            pleaseUpdate = true;
            StartCoroutine(PushTextOnScreen());
        }
    }

    IEnumerator PushTextOnScreen()
    {
        yield return new WaitForSeconds(0.25f);
        screenQuestion.GetComponent<TextMeshProUGUI>().text = newQuestion;
        answerA.GetComponent<TextMeshProUGUI>().text = newA;
        answerB.GetComponent<TextMeshProUGUI>().text = newB;
        answerC.GetComponent<TextMeshProUGUI>().text = newC;
        answerD.GetComponent<TextMeshProUGUI>().text = newD;
    }
}
