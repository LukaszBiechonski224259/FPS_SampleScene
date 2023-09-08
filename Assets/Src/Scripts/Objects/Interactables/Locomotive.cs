using UnityEngine;

public class Locomotive : Interactable
{

    public static Transform[] points;
    public float speed = 0f;

    private Transform target;
    private int waypointIndex;
    
    // Start is called before the first frame update
    void Start()
    {
        target = Waypoints.points[0];
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = target.position - transform.position;
        transform.Translate(direction.normalized * (speed * Time.deltaTime),Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWaypoint();
        }
    }

    void GetNextWaypoint()
    {
        waypointIndex++;
        target = Waypoints.points[waypointIndex];
    }
    
}
