using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Goal : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private Rigidbody2D rb;
    private int score = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {




        void OnTriggerExit2D(Collider2D col)
        {
            scoreText.text = (++score).ToString("0000");
            transform.position = Vector2(0, 0, 0);
        }
    }
}
