using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    private PlayerMovement playerMovement;     

    Animator anim;            


    void Awake()
    {
        playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (!playerMovement.moveable)
        {
            anim.SetTrigger("GameOver");

            if (Input.GetKeyDown(KeyCode.E))
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }
    }
}