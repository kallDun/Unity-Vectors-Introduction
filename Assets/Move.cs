using UnityEngine;

public class Move : MonoBehaviour {

    public Transform goal;
    public float speed = 0.4f;
    public float accuracy = 0.25f;

    void Start() 
    {
        
    }

    void LateUpdate() 
    {
        transform.LookAt(goal.position);
        Vector3 dir = goal.position - transform.position;
        if (dir.magnitude < accuracy) return;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
    }
}