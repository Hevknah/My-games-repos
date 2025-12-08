using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Spawningcode : MonoBehaviour
{
	GameObject spawnee;

	float spawnCooldown = 1f;
	private float spawnTime;
	public GameObject EnemyPrefab;
    public GameObject TreatPrefab;
	private object spawn;




	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
		spawnTime = spawnCooldown;
	}

    // Update is called once per frame
    void Update()
    {

		if (spawnTime > 0) spawnTime -= Time.deltaTime;

		if (spawnTime < 0)
		{
			Spawn();
			spawnTime = spawnCooldown;
		}
	}

	private void Spawn()
	{

		var spwan = Instantiate(TreatPrefab, transform.position, transform.rotation);



		var spwan2 = Instantiate(EnemyPrefab, transform.position, transform.rotation);

	}






}
