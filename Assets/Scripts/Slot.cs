using UnityEngine;

public class Slot : MonoBehaviour
{
    public UI Ui;
    public int Points = 10;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            OnBallEntered(other);
        }
    }

    private void OnBallEntered(Collider2D other)
    {
        ScorePoints();
    }
    private void ScorePoints()
    {
        // tell scorekeeper to add some amount of points
        Scorekeeper.Add(Points);
        Ui.ShowScore(Scorekeeper.GetScore());
    }
    //
}
