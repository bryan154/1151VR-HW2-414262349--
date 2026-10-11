using UnityEngine;

public class Journey : MonoBehaviour
{
    // 陣列存放角色要經過的座標。
    Vector3[] points = new Vector3[8];
    int number = 1;
    float speed = 3.0f;

    void Start()
    {
        points[0] = new Vector3(-6, -2, 0); // 起點
        points[1] = new Vector3(-5, -2, 0); // 往前走
        points[2] = new Vector3(-3, 2, 0);  // 第一跳的最高點
        points[3] = new Vector3(-2, 0, 0);  // 到第一個平台
        points[4] = new Vector3(1, 4, 0);   // 第二跳的最高點
        points[5] = new Vector3(2, 2, 0);   // 到第二個平台
        points[6] = new Vector3(5, 0, 0);   // 往下跳
        points[7] = new Vector3(6, -2, 0);  // 終點

        transform.position = points[0];
    }

    void Update()
    {
        // 還有下一個座標，才繼續移動。
        if (number < points.Length)
        {
            // MoveTowards 讓角色每一影格靠近目標。
            transform.position = Vector3.MoveTowards(
                transform.position, points[number], speed * Time.deltaTime);

            // 到達這個點後，換下一個點。
            if (transform.position == points[number])
            {
                number = number + 1;

                if (number == points.Length)
                {
                    Debug.Log("到達終點");
                }
            }
        }
    }
}
