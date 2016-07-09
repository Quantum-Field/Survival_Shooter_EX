using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
	public float restartDelay = 5f;

    Animator anim;
	float restartTimer;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (playerHealth.currentHealth <= 0)
        {
            anim.SetTrigger("GameOver");

			this.restartTimer += Time.deltaTime;

			if(this.restartTimer >= this.restartDelay)
			{
				Application.LoadLevel(Application.loadedLevel);
			}
        }
    }
}
