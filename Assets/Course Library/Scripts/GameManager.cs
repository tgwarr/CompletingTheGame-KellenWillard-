using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
	public List<GameObject> targets;
	public TextMeshProUGUI scoreText;
	private int score = 0;

    void Start()
    {
		StartCoroutine(TargetSpawner());
		UpdateScore(0);
    }
		
    void Update()
    {
        
    }

	IEnumerator TargetSpawner()
	{
		while(true)
		{
			yield return new WaitForSeconds(1.0f);
			int targetIndex = Random.Range(0, targets.Count);
			Instantiate(targets[targetIndex]);
		}
	}

	public void UpdateScore(int scoreToAdd)
	{
		score += scoreToAdd;
		if(score < 0)
		{
			score = 0;
		}
		scoreText.text = "Score: " + score;
	}

}
