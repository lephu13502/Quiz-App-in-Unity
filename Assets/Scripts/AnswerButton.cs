using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AnswerButton : MonoBehaviour
{
    [SerializeField] private GameObject answerABluePanel;
    [SerializeField] private GameObject answerAGreenPanel;
    [SerializeField] private GameObject answerARedPanel;

    [SerializeField] private GameObject answerBBluePanel;
    [SerializeField] private GameObject answerBGreenPanel;
    [SerializeField] private GameObject answerBRedPanel;

    [SerializeField] private GameObject answerCBluePanel;
    [SerializeField] private GameObject answerCGreenPanel;
    [SerializeField] private GameObject answerCRedPanel;

    [SerializeField] private GameObject answerDBluePanel;
    [SerializeField] private GameObject answerDGreenPanel;
    [SerializeField] private GameObject answerDRedPanel;

    [SerializeField] private GameObject answerA;
    [SerializeField] private GameObject answerB;
    [SerializeField] private GameObject answerC;
    [SerializeField] private GameObject answerD;

    [SerializeField] private AudioSource correctFX;
    [SerializeField] private AudioSource incorrectFX;

    [SerializeField] private GameObject currentScore;
    [SerializeField] private int scoreValue;
    [SerializeField] private int bestScore;
    [SerializeField] private GameObject bestDisplay;

    [SerializeField] private GameObject visual1;

    private void Start()
    {
        bestScore = PlayerPrefs.GetInt("BestScoreQuiz");
        bestDisplay.GetComponent<TextMeshProUGUI>().text = "Best score: " + bestScore;
    }

    private void Update()
    {
        currentScore.GetComponent<TextMeshProUGUI>().text = "Score: " + scoreValue;
    }

    public void AnswerA()
    {
        if (QuestionGenerate.actualAnswer == "A")
        {
            answerAGreenPanel.SetActive(true);
            answerABluePanel.SetActive(false);
            correctFX.Play();
            scoreValue += 5;
        }
        else
        {
            answerARedPanel.SetActive(true);
            answerABluePanel.SetActive(false);
            incorrectFX.Play();
            scoreValue = 0;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }
    public void AnswerB()
    {
        if (QuestionGenerate.actualAnswer == "B")
        {
            answerBGreenPanel.SetActive(true);
            answerBBluePanel.SetActive(false);
            correctFX.Play();
            scoreValue += 5;
        }
        else
        {
            answerBRedPanel.SetActive(true);
            answerBBluePanel.SetActive(false);
            incorrectFX.Play();
            scoreValue = 0;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }
    public void AnswerC()
    {
        if (QuestionGenerate.actualAnswer == "C")
        {
            answerCGreenPanel.SetActive(true);
            answerCBluePanel.SetActive(false);
            correctFX.Play();
            scoreValue += 5;
        }
        else
        {
            answerCRedPanel.SetActive(true);
            answerCBluePanel.SetActive(false);
            incorrectFX.Play();
            scoreValue = 0;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }
    public void AnswerD()
    {
        if (QuestionGenerate.actualAnswer == "D")
        {
            answerDGreenPanel.SetActive(true);
            answerDBluePanel.SetActive(false);
            correctFX.Play();
            scoreValue += 5;
        }
        else
        {
            answerDRedPanel.SetActive(true);
            answerDBluePanel.SetActive(false);
            incorrectFX.Play();
            scoreValue = 0;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }
    IEnumerator NextQuestion()
    {
        if (bestScore < scoreValue)
        {
            PlayerPrefs.SetInt("BestScoreQuiz", scoreValue);
            bestScore = scoreValue;
            bestDisplay.GetComponent<TextMeshProUGUI>().text = "Best score: " + scoreValue;
        }

        yield return new WaitForSeconds(2);

        visual1.SetActive(false);

        answerAGreenPanel.SetActive(false);
        answerBGreenPanel.SetActive(false);
        answerCGreenPanel.SetActive(false);
        answerDGreenPanel.SetActive(false);

        answerARedPanel.SetActive(false);
        answerBRedPanel.SetActive(false);
        answerCRedPanel.SetActive(false);
        answerDRedPanel.SetActive(false);

        answerABluePanel.SetActive(true);
        answerBBluePanel.SetActive(true);
        answerCBluePanel.SetActive(true);
        answerDBluePanel.SetActive(true);

        answerA.GetComponent<Button>().enabled = true;
        answerB.GetComponent<Button>().enabled = true;
        answerC.GetComponent<Button>().enabled = true;
        answerD.GetComponent<Button>().enabled = true;

        QuestionGenerate.displayingQuestion = false;
    }
}
