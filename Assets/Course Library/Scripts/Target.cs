using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
	private Rigidbody targetRB;
	private EventManager eventManager;
	public ParticleSystem expParticle;

    void Start()
    {
		eventManager = GameObject.Find("EventManager").GetComponent<EventManager>();
		targetRB = GetComponent<Rigidbody>();
		targetRB.AddForce(Vector3.up*Random.Range(14,19),ForceMode.Impulse);
		targetRB.AddTorque(Random.Range(-5,5),Random.Range(-5,5),Random.Range(-5,5),ForceMode.Impulse);
		transform.position = new Vector3(Random.Range(-5,5),-5,0);

    }
		
    void Update()
    {
        
    }


	private void OnMouseDown()
	{
		Destroy(gameObject);
		Instantiate(expParticle, transform.position, expParticle.transform.rotation);
		if(CompareTag("Bad"))
			{
				eventManager.targetDestroyed?.Invoke(-10);
			}
			else if(CompareTag("Good"))
		{
			eventManager.targetDestroyed?.Invoke(10);
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		eventManager.gameOverEvent?.Invoke();
		Destroy(gameObject);
	}
}
