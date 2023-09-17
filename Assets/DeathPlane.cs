using UnityEngine;

public class DeathPlane : MonoBehaviour
{
    // references
    public Transform playerRobot;
    public Transform AIRobot;

    public Vector3 playerResetPosition;
    public Vector3 AIResetPosition;

    public Transform ball;
    public Vector3 ballResetPosition;

    public Vector3 playerResetRotation = new Vector3(0, 180, 0);
    public Vector3 AIResetRotation = new Vector3(0, 0, 0);

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform == playerRobot)
        {
            // Reset position for Player Robot
            playerRobot.position = playerResetPosition;
    	      playerRobot.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
        }
        else if (other.transform == AIRobot)
        {
            // Reset position for AI Robot
            AIRobot.position = AIResetPosition;
	          AIRobot.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        }
        else if (other.transform == ball)
        {
            ball.position = ballResetPosition;
        }
    }
}
