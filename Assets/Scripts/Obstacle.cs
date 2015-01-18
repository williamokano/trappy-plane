using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour
{

    public Vector2 velocity = new Vector2(-4, 0);
    public float range = 4;

    // Use this for initialization
    void Start()
    {
        rigidbody2D.velocity = velocity;
        transform.position = new Vector3(transform.position.x, transform.position.y + Random.Range(-range / 2, range / 2), transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        //Die by being off screen
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.x < 0)
        {
            Destroy(gameObject);
        }
    }
}
