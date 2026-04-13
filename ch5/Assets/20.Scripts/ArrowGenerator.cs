using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    float span = 1.0f;
    float delta = 0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if(delta>span)
        {
            GameObject gp = Instantiate(arrowPrefab);
            float px = Ramdp.Range(-8f, 8f);
            goto.transform.position = new Vector3(px, 7, 0);
        }
    }
}
