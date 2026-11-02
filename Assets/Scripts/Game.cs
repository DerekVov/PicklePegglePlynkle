using UnityEngine;

public class Game : MonoBehaviour
{
    public UI Ui;
    private static bool isGameStarted = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() 
    {
        // show the start screen small change
        Ui.ShowStartScreen();
    }

    public void OnStartButtonClicked()
    {
        // hide start screen
        // remember oh wait we started
        Ui.HideStartScreen();
        isGameStarted = true;
        
    }

    public static bool IsGameNotStarted()
    {
        return !isGameStarted;
    }
    public static bool IsGameStarted()
    {
        return isGameStarted;
    }
}
