using UnityEngine;

public class AIGoalie : MonoBehaviour
{
    //references

    public Transform ball;

    public Transform goal;

    public float maxDistanceFromGoal = 10.0f;

    public float maxSpeed = 5.0f;

    public float turnSpeed = 2.0f;

    public float interceptDistance = 5.0f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Calculate the direction from the goalie to the ball
        Vector3 directionToBall = ball.position - transform.position;

        // Calculate the distance to the ball
        float distanceToBall = directionToBall.magnitude;

        // If the ball is within the intercept distance
        if (distanceToBall < interceptDistance)
        {
            // Calculate the desired velocity to move towards the ball
            Vector3 desiredVelocity = directionToBall.normalized * maxSpeed;

            // Calculate the force needed to reach the desired velocity
            Vector3 force = (desiredVelocity - rb.velocity) * rb.mass * turnSpeed;

            // Apply the force to the goalie's Rigidbody
            rb.AddForce(force);
        }

        // Calculate the distance from the goal
        float distanceFromGoal = Vector3.Distance(transform.position, goal.position);

        // If the AI goalie is beyond the maximum distance from the goal, move it back towards the goal
        if (distanceFromGoal > maxDistanceFromGoal)
        {
            // Calculate the direction to the goal
            Vector3 directionToGoal = goal.position - transform.position;

            // Calculate the desired velocity to move towards the goal
            Vector3 desiredVelocity = directionToGoal.normalized * maxSpeed;

            // Calculate the force needed to reach the desired velocity
            Vector3 force = (desiredVelocity - rb.velocity) * rb.mass * turnSpeed;

            // Apply the force to the goalie's Rigidbody
            rb.AddForce(force);
        }
    }
}
