using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform[] Point;  
    public float Movespeed;
    public int patrolDestination;

    void Update()
    {
        if (patrolDestination == 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, Point[0].position, Movespeed * Time.deltaTime);
            if (Vector2.Distance(transform.position, Point[0].position) < 0.1f)
            {
                transform.localScale = new Vector3(1, 1, 1);
                patrolDestination = 1;
            }

        }
        else if (patrolDestination == 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, Point[1].position, Movespeed * Time.deltaTime);
            if (Vector2.Distance(transform.position, Point[1].position) < 0.1f)
            {
                patrolDestination = 0;
                transform.localScale = new Vector3(-1, 1, 1);
            }
        }
    }
}
