using UnityEngine;

public class MovingWall : MonoBehaviour
{
    public float speed = 2f;

    public float distance = 3f;

    public bool moveHorizontally = false;

    private Vector3 startPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float movement = Mathf.PingPong(Time.time * speed, distance);

        Vector3 direction = moveHorizontally ? Vector3.right : Vector3.up;

        transform.position = startPosition + direction * movement;
    }
}
