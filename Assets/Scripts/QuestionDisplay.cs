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
    [SerializeField] private static string newQuestion;
    [SerializeField] private static string newA;
    [SerializeField] private static string newB;
    [SerializeField] private static string newC;
    [SerializeField] private static string newD;

    private void Start()
    {
        screenQuestion.GetComponent<TextMeshProUGUI>().text = "HOW TO MAKE A QUIZ GAME APP FOR MOBILE & PC IN UNITY";
        answerA.GetComponent<TextMeshProUGUI>().text = "A. Buy it";
        answerB.GetComponent<TextMeshProUGUI>().text = "B. Learn on Youtube";
        answerC.GetComponent<TextMeshProUGUI>().text = "C. Ask on Facebook";
        answerD.GetComponent<TextMeshProUGUI>().text = "D. Don't do it";
    }
}
