using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dreams : MonoBehaviour
{
    public GameObject sen_good;
    //public GameObject sen_mid;
    public GameObject sen_bad;

    public int jakosc_snu;
    public int rodzajSnu;

    public Text spanko;

    public int sen;

    public bool stage1;
    // Start is called before the first frame update
    void Start()
    {
        rodzajSnu = Random.Range(1, 2);
        StartCoroutine(Dream());
        jakosc_snu = 1;
        sen = 50;
    }

    // Update is called once per frame
    void Update()
    {
        spanko.text = sen.ToString();
    }

    IEnumerator Dream()
    {
        if (rodzajSnu == 1)
        {
            Instantiate(sen_good, transform.position, transform.rotation);
            Debug.Log("dobre spanko");
        }
        if (rodzajSnu == 2)
        {
            Instantiate(sen_bad, transform.position, transform.rotation);
            Debug.Log("zle spanko");
        }
        rodzajSnu = Random.Range(1, 3);

        yield return new WaitForSeconds(3);
        StartCoroutine(Dream());
    }

    IEnumerator DreamPointsFixes()
    {
        yield return new WaitForSeconds(1);
        sen += 1;
        StartCoroutine(DreamPointsFixes());
    }
}
