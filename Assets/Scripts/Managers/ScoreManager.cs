using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public static int score;
	private static int killEnemies;

	Text text;

	public static void AddScore(int score)
	{
		killEnemies++;
		int bonus = 0;
		if ((killEnemies % 10 == 0))
		{
			bonus = 100;
		}
		ScoreManager.score += (score + bonus);
	}

    void Awake ()
    {
        text = GetComponent <Text> ();
        score = 0;
		killEnemies = 0;
    }

    void Update ()
    {
        text.text = "Score: " + score;
    }
}
