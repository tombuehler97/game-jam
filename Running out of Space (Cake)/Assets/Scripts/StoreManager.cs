using UnityEngine;
using UnityEngine.UI;

public class StoreManager : MonoBehaviour
{
    public static int storage;
    private PlayerEconomy playerEconomy;

    private Text text;
    // Start is called before the first frame update
    void Awake()
    {
        playerEconomy = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerEconomy>();
        text = GetComponent<Text>();

        storage = playerEconomy.storedCakes;
    }

    // Update is called once per frame
    void Update()
    {
        storage = playerEconomy.storedCakes;
        text.text = "" + storage;
    }
}