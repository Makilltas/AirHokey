using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public AudioClip clip;
    private AudioSource audioSource;
    private int score;
    
    // Start is called before the first frame update
    void Start()
    {
      audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Puk"))
        {
            audioSource.PlayOneShot(clip);
            scoreText.text = (++score).ToString("D2");
            collision.transform.position = Vector3.zero;
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        }
    }
}
