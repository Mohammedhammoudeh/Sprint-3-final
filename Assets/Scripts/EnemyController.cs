using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float moveSpeed = 3f; // Speed at which the enemy moves
    private Transform player; // Reference to the player's Transform

    // Start is called before the first frame update
    void Start()
    {
        // Find the player object and get its Transform
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            // Move towards the player
            transform.position = Vector2.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);
        }
    }
}
