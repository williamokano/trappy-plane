using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour
{

    public GameObject rocks;
    public GUIText score;
    int gameScore = 0;

    // Use this for initialization
    void Start()
    {
        ChangeScore();
        InvokeRepeating("CreateObstacle", 1f, 1.5f);
    }

    void CreateObstacle()
    {
        Instantiate(rocks);
        gameScore++;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            if (Application.platform == RuntimePlatform.Android)
            {
                Application.LoadLevel("MainMenu");
            }
        }
    }

    void LateUpdate()
    {
        ChangeScore();
    }
    
    void ChangeScore()
    {
        score.text = "Score: " + gameScore.ToString();
    }

}
