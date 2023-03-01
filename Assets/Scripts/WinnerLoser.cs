using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinnerLoser : MonoBehaviour
{
    GameObject other;
    [SerializeField] GameObject selfprefab;
    [SerializeField] GameObject scissorprefab;

    private void OnCollisionEnter()
    {
        if (other.gameObject.tag == "rock") // if(collision.otherCollider.tag == "rock")
        {
            //other = collision.gameObject;
            //Instantiate(selfprefab, other.GetComponent<Transform>().localPosition, Quaternion.identity);
            //Destroy(collision.gameObject);
            Debug.Log("rock collison");
        }

        if (other.gameObject.tag == "scissor") //if (collision.otherCollider.tag == "scissors")
        {
            //other = collision.gameObject;
            //Instantiate(scissorprefab, transform.localPosition, Quaternion.identity);
            //Destroy(gameObject);
            Debug.Log("scissor collison");
        }

        Debug.Log("any collison");
    }
}
