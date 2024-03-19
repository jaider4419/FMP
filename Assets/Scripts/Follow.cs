using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 3f; 
    private float stoppingDistance = 0f; 
    public float reloadDelay = 1f; 
    public Collider boundaryCollider; 
    public string nextSceneName;

    private bool isFollowingPlayer = false;

    void Update()
    {
        if (player == null)
            return;

        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        bool playerWithinBoundary = boundaryCollider.bounds.Contains(player.position);

        if (distanceToPlayer < stoppingDistance || !playerWithinBoundary)
        {
            isFollowingPlayer = false; 
        }
        else
        {
            isFollowingPlayer = true;

            transform.position = Vector3.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Following and touching?");
        }
    }

}