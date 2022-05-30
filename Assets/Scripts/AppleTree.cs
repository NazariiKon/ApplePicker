using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    public GameObject applePrefab;
    public float speed = 5f;
    public float leftAndRightEdge = 10f;
    public float chanceToChangeDirections = 0.001f;
    public float secondsBetweenAppleDrops = 4f;
    public int appleCounter = 0;
    public int newLevel = 5;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DropApple", 2f);
    }

    void DropApple()
    {
        appleCounter++;
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", secondsBetweenAppleDrops);

        if (appleCounter == newLevel)
        {
            speed *= 1.1f;
            //chanceToChangeDirections *= 1.1f;
            secondsBetweenAppleDrops *= 0.8f;
            if (newLevel < 40)
                newLevel += 5;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        }
    }

    private void FixedUpdate()
    {
        if (Random.value < chanceToChangeDirections)
        {
            speed *= -1;
        }
    }
}
