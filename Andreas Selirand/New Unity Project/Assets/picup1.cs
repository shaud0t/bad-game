using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class picup1 : MonoBehaviour
{
    public int score;
    public AudioSource audio;
    public GameObject scoreText;
   // public int Health;                                     //what the dog doin
    public GameObject HealthText;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.GetComponent<Text>().text = "Score:" + score;
       // Health = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "coin")
        {   audio.Play();
            Destroy(collision.gameObject);
            score++;
            scoreText.GetComponent<Text>().text = "Score:" + score;
        }
            
    }
}
