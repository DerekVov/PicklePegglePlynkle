using UnityEngine;
using TMPro;
public class UI : MonoBehaviour
{
    public CanvasGroup canvasGroup; 
    public TMP_Text ScoreText;
    public void ShowScore(int score)
    {
        ScoreText.text = score.ToString();
    }

    public void ShowStartScreen()
    {
        CanvasGroupDisplayer.Show(canvasGroup);
    }
    public void HideStartScreen()
    {
        CanvasGroupDisplayer.Hide(canvasGroup);
    }
}
