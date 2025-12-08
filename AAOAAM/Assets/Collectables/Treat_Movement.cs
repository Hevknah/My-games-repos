using UnityEngine;
using System.Collections;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;


public class Treat_Movement : MonoBehaviour
{
    //Timing code
    public float stepDistance = 1f;
    int horzSteps = 10;
    float stepTime = 1.5f;

    //Animation
    private Animator anim;

    //Score
    public int score, requiredScore;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(StepBasedMovement());

    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator StepBasedMovement()
    {
        while (true)
        {
            //should move every couple seconds
            transform.position += Vector3.down * stepDistance;
            yield return new WaitForSeconds(stepTime);

        }

    }


}




       
