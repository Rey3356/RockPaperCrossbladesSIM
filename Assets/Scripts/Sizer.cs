using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sizer : MonoBehaviour
{
    [SerializeField] Slider sizeslide;
    GameObject[] rocks;
    GameObject[] papers;
    GameObject[] scissors;
    Transform size;

    private void Start()
    {
        size = GameObject.FindGameObjectWithTag("rock").GetComponent<Transform>();//just caches the inital size of the objects
    }

    private void Update()
    {
        rocks = GameObject.FindGameObjectsWithTag("rock");
        papers = GameObject.FindGameObjectsWithTag("paper");
        scissors = GameObject.FindGameObjectsWithTag("scissors");
        size.localScale = new Vector3(0.2f + sizeslide.normalizedValue, 0.2f + sizeslide.normalizedValue, 0.2f + sizeslide.normalizedValue);
        if (size.localScale.x <= 1.2f && size.localScale.x >= 0.2f)
        {
            int lr = rocks.Length;
            for (int i = 0; i < lr; i++)
            {
                rocks[i].transform.localScale = size.localScale;
            }

            int lp = papers.Length;
            for (int i = 0; i < lp; i++)
            {
                papers[i].transform.localScale = size.localScale;
            }

            int ls = scissors.Length;
            for (int i = 0; i < ls; i++)
            {
                scissors[i].transform.localScale = size.localScale;
            }
        }
        
    }

}
