using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 3f;
    private float stoppingDistance = 0f;


    void Update()
    {
        if (player == null)
            return;

        float distanceToPlayer = Vector3.Distance(transform.position, player.position);


        if (distanceToPlayer < stoppingDistance)
        {
        }
        else
        {

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