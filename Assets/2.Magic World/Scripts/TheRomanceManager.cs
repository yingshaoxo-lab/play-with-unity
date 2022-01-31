using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
using TMPro;

public class TheRomanceManager : MonoBehaviour
{
    public GameObject firework1;
    public GameObject firework2;
    public GameObject heartFlow;
    public GameObject loveText;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("StartTheHeartFlow", 2f);

        Invoke("enhanceTheHeartColor1", 5f);
        Invoke("ShowHeart", 5f);

        Invoke("enhanceTheHeartColor2", 7f);
        Invoke("enhanceTheHeartColor3", 9f);

        Invoke("StartTheFirework", 12f);
        Invoke("ShowTheText", 30f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void StartTheHeartFlow()
    {
        heartFlow.SetActive(true);
    }

    void ShowHeart()
    {
        VisualEffect vfx = heartFlow.GetComponent<VisualEffect>();
        vfx.SetFloat("zeroToDisableHeart", 1); //0 to disable, 1 to enable
    }

    void enhanceTheHeartColor1()
    {
        float basicNumber = 0.01f;
        basicNumber = basicNumber * 1;

        VisualEffect vfx = heartFlow.GetComponent<VisualEffect>();
        vfx.SetFloat("particalSize", basicNumber);
    }

    void enhanceTheHeartColor2()
    {
        float basicNumber = 0.01f;
        basicNumber = basicNumber * 2;

        VisualEffect vfx = heartFlow.GetComponent<VisualEffect>();
        vfx.SetFloat("particalSize", basicNumber);
    }


    void enhanceTheHeartColor3()
    {
        float basicNumber = 0.01f;
        basicNumber = basicNumber * 3;

        VisualEffect vfx = heartFlow.GetComponent<VisualEffect>();
        vfx.SetFloat("particalSize", basicNumber);
    }

    void StartTheFirework()
    {
        VisualEffect vfx = heartFlow.GetComponent<VisualEffect>();
        vfx.SetFloat("setZeroToDisableOutsidePoint", 0.0f);

        firework1.SetActive(true);
        firework2.SetActive(true);
    }

    void ShowTheText()
    {
        enhanceTheHeartColor1();
        StartCoroutine(TypeTextSlowly());
        loveText.SetActive(true);
    }

    IEnumerator TypeTextSlowly()
    {
        // string text = "  I   Love You\nToo";
        string text = "";
        loveText.GetComponent<TextMeshPro>().text = text;
        yield return new WaitForSeconds(1f);
        text = "I";
        loveText.GetComponent<TextMeshPro>().text = text;
        yield return new WaitForSeconds(1f);
        text = "  I   Love";
        loveText.GetComponent<TextMeshPro>().text = text;
        yield return new WaitForSeconds(1f);
        text = "  I   Love You";
        loveText.GetComponent<TextMeshPro>().text = text;
        yield return new WaitForSeconds(1f);
        text = "  I   Love You\nToo";
        loveText.GetComponent<TextMeshPro>().text = text;
    }
}
