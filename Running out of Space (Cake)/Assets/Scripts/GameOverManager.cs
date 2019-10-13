using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public PlayerEconomy playerEconomy;     

    Animator anim;                          
    float restartTimer;                     


    void Awake()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().speed == 0)
        {
            anim.SetTrigger("GameOver");

            if (Input.GetKeyDown(KeyCode.E))
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }
    }
}