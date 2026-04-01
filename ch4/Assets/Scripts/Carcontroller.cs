using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    float Speed = 0;
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - this.startPos.x;

            this.Speed = swipeLength / 500.0f;
        }
        transform.Translate(this.Speed, 0, 0);
        this.Speed *= 0.98f;
    }
}
