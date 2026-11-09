using UnityEngine;

public class Slot : MonoBehaviour
{
    public UI Ui;
    public int Points = 10;
    public GameObject FireworksParticlePrefab;
    public Sounds Sounds;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            OnBallEntered(other);
        }
    }

    private void OnBallEntered(Collider2D ball)
    {
        ScorePoints();
        SpawnParticles(ball);
        PlayFireworksSound();
    }

    private void PlayFireworksSound()
    {
        Sounds.PlayFireworksSound();
        
    }

    private void SpawnParticles(Collider2D ball)
    {
        Vector3 particlePosition = GetParticlePosition(ball);
        Instantiate(FireworksParticlePrefab, transform.position, Quaternion.identity);
    }

    private Vector3 GetParticlePosition(Collider2D ball)
    {
        Vector3 ballPosition = ball.transform.position;
        ballPosition.y = ballPosition.y + 0.25f;
        return ballPosition;
    }

    private void ScorePoints()
    {
        // tell scorekeeper to add some amount of points
        Scorekeeper.Add(Points);
        Ui.ShowScore(Scorekeeper.GetScore());
    }
    //
}
