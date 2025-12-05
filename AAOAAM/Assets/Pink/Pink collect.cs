using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;

public class Pinkcollect : MonoBehaviour
{

    public int score, requiredScore;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (score >= requiredScore)
        {
            //winScreen.SetActive(true);
        }
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("collectable"))
        {
            Destroy(other.gameObject);
            ++score;
        }
    }









}
