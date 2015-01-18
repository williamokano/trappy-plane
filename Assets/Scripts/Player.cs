using UnityEngine;
using System.Collections;


public class Player : MonoBehaviour
{

    public Vector2 jumpForce = new Vector2(0, 300);
    public GameObject soundForJumping;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Jump
        if (Input.GetKeyDown("space") || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
        {
            rigidbody2D.velocity = Vector2.zero;
            rigidbody2D.AddForce(jumpForce);

            AudioSource sound = soundForJumping.GetComponent<AudioSource>();
            sound.loop = false;
            sound.Play();
        }

        //Correct the player angle
        float angle = rigidbody2D.velocity.y * 15;
        angle = angle < -80 ? -80 : angle;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        //Die by being off screen
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if(screenPosition.y > Screen.height || screenPosition.y < 0)
        {
            Die();
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Die();
    }

    void Die()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

}
