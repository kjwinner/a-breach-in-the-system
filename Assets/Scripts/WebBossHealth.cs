using UnityEngine;
using System.Collections;
using UnityEngine.UI;
/*
The WebBossHealth script handles the health of the WebBoss virus in the final level.
*/
public class WebBossHealth : MonoBehaviour {
	public int startingHealth = 500;
    public int currentHealth;
    float timer;
    bool isDead;
    public WebBossGameOverManager manager;

    public Slider BossHealthSlider;
    Animator anim;

    /*
    The Awake function sets the isDead value to false, gets the Animator component,
    and sets the currentHealth equal to the startingHealth.
    */
	void Awake ()
    {
    	isDead = false;
        anim = GetComponent <Animator> ();
        currentHealth = startingHealth;
    }
	
    /*
    The Update function updates the value of the WebBoss's health.
    It also calls the GameLost and GameWon functions when the time has either run
    out or when the WebBoss is dead, respectively.
    A timer also evaluates whether the WebBoss has already been killed and if enough time
    has passed, which would end the game.
    */
	void Update ()
	{
		timer += Time.deltaTime;
		BossHealthSlider.value = currentHealth;
		if (timer>54)
		{
			manager.GameLost();
		}
		
		if (isDead && timer>3)
		{
			manager.GameWon();
		}
	}

    /*
    The TakeDamage function is called by other scripts, and is called when the WebBoss
    is attacked.  Its health is decreased and its health slider is updated to show that.
    When the health is less than zero, the Death function is called.
    */
	public void TakeDamage ()
    {
        currentHealth -= 5;
        if(currentHealth <= 0)
        {
            Death ();
        }
    }

    /*
    The Death function is called when the currentHealth is less than 0.  It sets the 
    "Death" trigger in the Animator component, which triggers the death animation.
    It also sets isDead to true and restarts the timer.
    */
    void Death ()
    {
    	isDead = true;
        anim.SetTrigger ("Death");
        timer = 0f;
    }
}
