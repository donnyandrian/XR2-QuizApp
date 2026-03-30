using UnityEngine;

public class QuestionGenerate : MonoBehaviour
{
    public static string actualAnswer;
    public static bool displayingQuestion = false;
    public int questionNumber;

    void Update()
    {
        if (displayingQuestion == false)
        {
            displayingQuestion = true;
            questionNumber = Random.Range(1, 6);
            switch (questionNumber)
            {
                case 1:
                {
                    QuestionDisplay.newQuestion = "How bla bla bla (A)";
                    QuestionDisplay.newA = "A. Lots and Lots";
                    QuestionDisplay.newB = "B. None";
                    QuestionDisplay.newC = "C. Hardly any";
                    QuestionDisplay.newD = "D. Six";
                    actualAnswer = "A";
                    break;
                }
                case 2:
                {
                    QuestionDisplay.newQuestion = "Q2 (C)";
                    QuestionDisplay.newA = "A. Lots and Lots";
                    QuestionDisplay.newB = "B. None";
                    QuestionDisplay.newC = "C. Hardly any";
                    QuestionDisplay.newD = "D. Six";
                    actualAnswer = "C";
                    break;
                }
                case 3:
                {
                    QuestionDisplay.newQuestion = "Q3 (B)";
                    QuestionDisplay.newA = "A. Lots and Lots";
                    QuestionDisplay.newB = "B. None";
                    QuestionDisplay.newC = "C. Hardly any";
                    QuestionDisplay.newD = "D. Six";
                    actualAnswer = "B";
                    break;
                }
                case 4:
                {
                    QuestionDisplay.newQuestion = "Q4 (D)";
                    QuestionDisplay.newA = "A. Lots and Lots";
                    QuestionDisplay.newB = "B. None";
                    QuestionDisplay.newC = "C. Hardly any";
                    QuestionDisplay.newD = "D. Six";
                    actualAnswer = "D";
                    break;
                }
                case 5:
                {
                    QuestionDisplay.newQuestion = "Q5 (A)";
                    QuestionDisplay.newA = "A. Lots and Lots";
                    QuestionDisplay.newB = "B. None";
                    QuestionDisplay.newC = "C. Hardly any";
                    QuestionDisplay.newD = "D. Six";
                    actualAnswer = "A";
                    break;
                }
                default:
                    break;
            }
            QuestionDisplay.needUpdate = true;
        }
    }
}
