using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    public GameObject TextObject;
    public GameObject TextObjectGameOver;
    public GameObject TextObjectVictory;
    Text textComponent;
    Text textComponentGameOver;
    Text textComponentVictory;
    public AudioClip CoinSound;
    public AudioClip hitSound;
    public AudioClip destroySound;
    private int coin;
    private Animation anim;

    void Start()
    {
        textComponent = TextObject.GetComponent<Text>();
        textComponentGameOver = TextObjectGameOver.GetComponent<Text>();
        textComponentVictory = TextObjectVictory.GetComponent<Text>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Coin")
        {
            coin = coin + 1 * 100;
            textComponent.text = "Score: " + coin.ToString();
            textComponentGameOver.text = "Score is just: " + coin.ToString();
            textComponentVictory.text = "Total Score: " + coin.ToString();
            AudioSource.PlayClipAtPoint(CoinSound, transform.position);
            Destroy(other.gameObject);
        }
        if (other.tag == "Death")
        {
            Destroy(this.gameObject);
        }
        if(other.tag=="groot")
        {
            AudioSource.PlayClipAtPoint(hitSound, transform.position);
        }

        if (other.tag == "Planet")
        {
            anim = other.GetComponent<Animation>();
            anim.PlayQueued("planet");
            AudioSource.PlayClipAtPoint(destroySound, transform.position);
            StartCoroutine(Pause());
            Destroy(other.gameObject);
        }
    }

    IEnumerator Pause()
    {
        yield return new WaitForSeconds(50);
    }
}
