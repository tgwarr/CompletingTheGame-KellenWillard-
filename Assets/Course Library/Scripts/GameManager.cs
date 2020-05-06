using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public List<GameObject> targets;

    void Start()
    {
		StartCoroutine(TargetSpawner());
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

	private void OnMouseDown()
	{
		Destroy(gameObject);
	}

	private void OnTriggerEnter(Collider other)
	{
		Destroy(gameObject);
	}
}
