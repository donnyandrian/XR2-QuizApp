using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButtons : MonoBehaviour
{
    public GameObject[] answerA = new GameObject[4];
    public GameObject[] answerB = new GameObject[4];
    public GameObject[] answerC = new GameObject[4];
    public GameObject[] answerD = new GameObject[4];

    public GameObject currentScore;
    public int scoreValue;
    public GameObject bestScore;
    public int bestScoreValue;

    private void IsEnableAllButtons(bool enabled = true)
    {
        answerA[3].GetComponent<Button>().enabled = enabled;
        answerB[3].GetComponent<Button>().enabled = enabled;
        answerC[3].GetComponent<Button>().enabled = enabled;
        answerD[3].GetComponent<Button>().enabled = enabled;
    }

    private void CorrectAnswer(string option, GameObject[] answer)
    {
        if (QuestionGenerate.actualAnswer == option)
        {
            answer[1].SetActive(true);
            answer[0].SetActive(false);
            scoreValue += 5;
        }
        else
        {
            answer[2].SetActive(true);
            answer[0].SetActive(false);
            scoreValue = 0;
        }

        IsEnableAllButtons(false);
        StartCoroutine(NextQuestion());
    }

    void Start()
    {
        bestScoreValue = PlayerPrefs.GetInt("BestScoreQuiz");
        bestScore.GetComponent<TMPro.TextMeshProUGUI>().text = "Best: " + bestScoreValue;
    }

    void Update()
    {
        currentScore.GetComponent<TMPro.TextMeshProUGUI>().text = "Score: " + scoreValue;
    }

    public void AnswerA()
    {
        CorrectAnswer("A", answerA);
    }

    public void AnswerB()
    {
        CorrectAnswer("B", answerB);
    }

    public void AnswerC()
    {
        CorrectAnswer("C", answerC);
    }

    public void AnswerD()
    {
        CorrectAnswer("D", answerD);
    }

    private void ResetAnswer(GameObject[] answer)
    {
        answer[0].SetActive(true);
        answer[1].SetActive(false);
        answer[2].SetActive(false);
    }

    IEnumerator NextQuestion()
    {
        if (bestScoreValue < scoreValue)
        {
            PlayerPrefs.SetInt("BestScoreQuiz", scoreValue);
            bestScoreValue = scoreValue;
            bestScore.GetComponent<TMPro.TextMeshProUGUI>().text = "Best: " + scoreValue;
        }
        yield return new WaitForSeconds(0.25f);

        ResetAnswer(answerA);
        ResetAnswer(answerB);
        ResetAnswer(answerC);
        ResetAnswer(answerD);

        IsEnableAllButtons(true);

        QuestionGenerate.displayingQuestion = false;
    }
}
