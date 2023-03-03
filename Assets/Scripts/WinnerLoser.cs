using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinnerLoser : MonoBehaviour
{
    [SerializeField] OBJScOb SCOB;
    GameObject other;

    void OnCollisionEnter(Collision collision)
    {
        if (gameObject.tag == "rock")
        {
            if (collision.collider.tag == "scissors") // win
            {
                other = collision.gameObject;
                Instantiate(SCOB.Objects[0], other.GetComponent<Transform>().localPosition, Quaternion.identity);
                Destroy(collision.gameObject);
                Debug.Log("scissors collison");
            }

        }

        if (gameObject.tag == "paper")
        {
            if (collision.collider.tag == "rock") //win
            {
                other = collision.gameObject;
                Instantiate(SCOB.Objects[1], other.GetComponent<Transform>().localPosition, Quaternion.identity);
                Destroy(collision.gameObject);
                Debug.Log("rock collison");
            }

        }

        if (gameObject.tag == "scissors")
        {
            if (collision.collider.tag == "paper") //win
            {
                other = collision.gameObject;
                Instantiate(SCOB.Objects[2], other.GetComponent<Transform>().localPosition, Quaternion.identity);
                Destroy(collision.gameObject);
                Debug.Log("paper collison");
            }
        }

    }

}

