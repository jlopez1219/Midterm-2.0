using UnityEngine;
using System.Collections;
public class FollowPlayer : MonoBehaviour
{
    public Transform player;

    public float speed = 5f;
    public float delay = 20f;
    public void IncreaseSpeed(float amount)
    {
        speed += amount;
    }
    private bool canMove = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(WaitBeforeFollowing());
    }

    IEnumerator WaitBeforeFollowing()
    {
        yield return new WaitForSeconds(delay);
        canMove = true;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (canMove) 
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                player.position,
                speed * Time.deltaTime);
        }
    }
}
