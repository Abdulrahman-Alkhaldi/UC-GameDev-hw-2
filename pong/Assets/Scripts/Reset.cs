using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Reset : MonoBehaviour
{
    Rigidbody2D RB;
    public Text Player1;
    public Text Player2;
    public int speed = 7;
    int Score1 = 1, Score2 = 1;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player1")
        {
            RB.velocity = new Vector2(0, 0);
            Invoke("Launch", 1);
            Player2.text = Score2++.ToString();
            transform.position = new Vector2(0, 0);
            
        }
        else if (col.gameObject.tag == "Player2")
        {
            RB.velocity = new Vector2(0, 0);
            Invoke("Launch", 1);
            Player1.text = Score1++.ToString();
            transform.position = new Vector2(0, 0);
            
        }

        //SceneManager.LoadScene("Level1");
    }
    void Launch()
    {
        float direction = Random.Range(0, 1);
        if (direction == 0f)
        {
            RB.velocity = new Vector2(-speed, 0);
        }
        else
        {
            RB.velocity = new Vector2(speed, 0);
        }
    }
}
