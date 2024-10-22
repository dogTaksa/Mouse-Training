using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Target : MonoBehaviour
{
    public int score;
    public GameObject Text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        gameObject.GetComponent<AudioSource>().Play();
        score++;
        Text.GetComponent<TextMeshPro>().text = score.ToString();

        gameObject.transform.position = new Vector2(Random.Range(-8.5f, 8.5f), Random.Range(-4.5f, 4.5f));
    }
}
