using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinController : MonoBehaviour
{
    public GameObject TextObject;
    Text textComponent;
    public AudioClip CoinSound;
    public int coin;

    void Start()
    {
        textComponent = TextObject.GetComponent<Text>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Coin")
        {
            coin = coin + 1 * 100;
            textComponent.text = "Score: " + coin.ToString();
            AudioSource.PlayClipAtPoint(CoinSound, transform.position);
            Destroy(other.gameObject);
        }
    }
}
