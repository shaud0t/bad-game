using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int hp;
    public GameObject myhealth;
    public GameObject spawner;
    public GameObject WinText;
    public GameObject instruct;
    // Start is called before the first frame update
    void Start()
    {
        hp = 10;
        myhealth.GetComponent<Text>().text = "health" + hp;


       
    }

    // Update is called once per frame-.
    void Update()
    {
        myhealth.GetComponent<Text>().text = "health" + hp;
        if (hp <= 0)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel(Application.loadedLevel);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
            Debug.Log("See lõpetab mängu");
        }
       
    }
    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "dangerblock")
        {

            hp--;
        }

        if (collision.gameObject.tag == "finish")
        {
            spawner.SetActive(true);
            WinText.SetActive(true);
            instruct.SetActive(true);
        }
        
        


    }

    
}
