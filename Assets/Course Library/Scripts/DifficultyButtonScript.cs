using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButtonScript : MonoBehaviour
{
	private Button button;
	public EventManager eventManager;
	public int difficulty;

    void Start()
    {
		button = GetComponent<Button>();
		button.onClick.AddListener(SetDifficulty);
    }

 
    void Update()
    {
        
    }

	void SetDifficulty()
	{
		Debug.Log(gameObject.name + " was pressed.");
		eventManager.startGameEvent?.Invoke(difficulty);
	}
}
