using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    public AudioClip CoinSound;

    public int coin;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Coin")
        {
            coin = coin + 1;
            AudioSource.PlayClipAtPoint(CoinSound, transform.position);
            Destroy(other.gameObject);
        }
    }
}
