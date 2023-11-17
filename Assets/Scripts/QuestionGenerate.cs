using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerate : MonoBehaviour
{
    public static string actualAnswer;
    public static bool displayingQuestion = false;
    public int questionNumber;
    private int previousNumber;
    [SerializeField] private GameObject visual1;

    private void Update()
    {
        if (displayingQuestion == false)
        {
            displayingQuestion = true;
            while (questionNumber == previousNumber)
            {
                questionNumber = Random.Range(1, 6);
            }
            if (questionNumber == 1)
            {
                QuestionDisplay.newQuestion = "How to make quiz app game in Unity?";
                QuestionDisplay.newA = "A. Buy it";
                QuestionDisplay.newB = "B. Learn on Youtube";
                QuestionDisplay.newC = "C. Ask on Facebook";
                QuestionDisplay.newD = "D. Don't do it";
                actualAnswer = "B";
            }
            if (questionNumber == 2)
            {
                QuestionDisplay.newQuestion = "Who is the brother of Luigi?";
                QuestionDisplay.newA = "A. D.K.";
                QuestionDisplay.newB = "B. Toad";
                QuestionDisplay.newC = "C. Mario";
                QuestionDisplay.newD = "D. Link";
                actualAnswer = "C";
            }
            if (questionNumber == 3)
            {
                QuestionDisplay.newQuestion = "Where is Japan?";
                QuestionDisplay.newA = "A. Asia";
                QuestionDisplay.newB = "B. North America";
                QuestionDisplay.newC = "C. Europe";
                QuestionDisplay.newD = "D. Africa";
                actualAnswer = "A";
            }
            if (questionNumber == 4)
            {
                QuestionDisplay.newQuestion = "Who won the 2023 Ballon D'or?";
                QuestionDisplay.newA = "A. Anh Liem";
                QuestionDisplay.newB = "B. Anh Thuyen";
                QuestionDisplay.newC = "C. Erling Haaland";
                QuestionDisplay.newD = "D. Lionel Messi";
                actualAnswer = "D";
            }
            if (questionNumber == 5)
            {
                QuestionDisplay.newQuestion = "Who is that Pokemon?";
                QuestionDisplay.newA = "A. Bulbasour";
                QuestionDisplay.newB = "B. Charizard";
                QuestionDisplay.newC = "C. Pikachu";
                QuestionDisplay.newD = "D. Pichu";
                visual1.SetActive(true);
                actualAnswer = "C";
            }
            QuestionDisplay.pleaseUpdate = false;
            previousNumber = questionNumber;
        }
    }
}
