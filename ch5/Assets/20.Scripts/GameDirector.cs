using UnityEngine;

public class GameDirector : MonoBehaviour
{
    GameObject hpGauge
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
    }

    // Update is called once per frame
    void Update()
    {
        this.hpGauge.getComponent<image>().fillAmount -= 0.1f;
    }
}
