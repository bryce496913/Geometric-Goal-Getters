using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
    //references
    public Transform ball;
    public int playerScore = 0;
    public int AIScore = 0;
    public Vector3 ballResetPosition;
    public Text playerScoreText;
    public Text AIScoreText;

    public EndGame endGameScript;

    public Transform playerRobot;
    public Transform AIRobot;

    public Vector3 playerResetPosition = new Vector3(0, 0.3f, 6);
    public Vector3 AIResetPosition = new Vector3(0, 0.3f, -6);

    public Vector3 playerResetRotation = new Vector3(0, 180, 0);
    public Vector3 AIResetRotation = new Vector3(0, 0, 0);

    public AudioSource cheerSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform == ball)
        {
            if (transform.position.z > 0)
            {
                AIScore++;
                AIScoreText.text = AIScore.ToString();
            }
            else
            {
                playerScore++;
                playerScoreText.text = playerScore.ToString();
            }

            ball.position = ballResetPosition;

            // Reset the positions of the AI and Player robots
            playerRobot.position = playerResetPosition;
            AIRobot.position = AIResetPosition;

            playerRobot.rotation = Quaternion.Euler(playerResetRotation);
            AIRobot.rotation = Quaternion.Euler(AIResetRotation);

            // Call a method in EndGame script to update scores
            endGameScript.UpdateScores(playerScore, AIScore);

            cheerSound.Play();
        }
    }
}
