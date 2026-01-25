using UnityEngine;

public class Clock : MonoBehaviour
{
    [Header("Time Hands")]
    public GameObject hourHand;
    public GameObject minuteHand;
    public GameObject secondHand;
    public GameObject pivotPoint;

    
    void Update()
    {
        System.DateTime currentTime = System.DateTime.Now;

        float hours = currentTime.Hour % 12;
        float minutes = currentTime.Minute;
        float seconds = currentTime.Second;

        //所有的指针初始指向12点方向
        float hourAngle = (hours + minutes / 60f) * 30f; //每小时30度
        float minuteAngle = (minutes + seconds / 60f) * 6f; //每分钟6度
        float secondAngle = seconds * 6f; //每秒钟6度

        //直接设置gameobject的rotation.x属性90+angle
        hourHand.transform.localEulerAngles = new Vector3(90f+hourAngle, 0f, -90f);
        minuteHand.transform.localEulerAngles = new Vector3(90f+minuteAngle, 0f, -90f);
        secondHand.transform.localEulerAngles = new Vector3(90f+secondAngle, 0f, -90f);


        //Debug.Log($"Time: {hours}:{minutes}:{seconds} | Angles - Hour: {hourAngle}, Minute: {minuteAngle}, Second: {secondAngle}");


    }

}
