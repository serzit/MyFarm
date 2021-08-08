using System.Collections;
using UnityEngine;

public class ItemNudge : MonoBehaviour
{
    private WaitForSeconds pause;

    private bool isAnimating = false;

    private void Awake()
    {
        pause = new WaitForSeconds(0.04f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!isAnimating)
        {
            if(gameObject.transform.position.x < collision.gameObject.transform.position.x)
            {
                StartCoroutine(RotateAntiClock());
            } else
            {
                StartCoroutine(RotateClock());
            }

            //play rustle sound if player
            if(collision.gameObject.tag == "Player")
            {
                AudioManager.Instance.PlaySound(SoundName.effectRustle);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!isAnimating)
        {
            if (gameObject.transform.position.x > collision.gameObject.transform.position.x)
            {
                StartCoroutine(RotateAntiClock());
            }
            else
            {
                StartCoroutine(RotateClock());
            }

            //play rustle sound if player
            if (collision.gameObject.tag == "Player")
            {
                AudioManager.Instance.PlaySound(SoundName.effectRustle);
            }
        }
    }

    IEnumerator RotateAntiClock()
    {
        isAnimating = true;

        for (int i = 0; i < 4; i++)
        {
            gameObject.transform.GetChild(0).Rotate(0f, 0f, 2f);
            yield return pause;
        }

        for (int i= 0; i < 5; i++)
        {
            gameObject.transform.GetChild(0).Rotate(0f, 0f, -2f);
            yield return pause;
        }

        gameObject.transform.GetChild(0).Rotate(0f, 0f, 2f);

        yield return pause;

        isAnimating = false;
    }
    IEnumerator RotateClock()
    {
        isAnimating = true;

        for (int i = 0; i < 4; i++)
        {
            gameObject.transform.GetChild(0).Rotate(0f, 0f, -2f);
            yield return pause;
        }

        for (int i = 0; i < 5; i++)
        {
            gameObject.transform.GetChild(0).Rotate(0f, 0f, 2f);
            yield return pause;
        }

        gameObject.transform.GetChild(0).Rotate(0f, 0f, -2f);

        yield return pause;

        isAnimating = false;
    }
}
