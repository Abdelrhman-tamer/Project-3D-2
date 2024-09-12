using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{

    public Player colStop;
    public Text gameOver;

    public Button ButtonHider;

    void Start()
    {
        gameOver.enabled = false; // You may need to use .SetActive(false);

        ButtonHider.enabled = false;
        ButtonHider.gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            colStop.enabled = false;
            gameOver.enabled = true;
            ButtonHider.enabled = true;
            ButtonHider.gameObject.SetActive(true);
        }
    }
}
