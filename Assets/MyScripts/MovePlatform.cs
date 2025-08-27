using UnityEngine;
using UnityEngine.UIElements;

public class MovePlatform : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public AudioSource moveSound;
    private GameObject wayPoint;


    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        wayPoint = GameObject.Find("FinishWP");
       
    }

    // Update is called once per frame
    void LateUpdate()
    {
        MovePlatformWayPoint();
    }
    private void MovePlatformWayPoint()
    {
        if (transform.position != wayPoint.transform.position)
        {
            Vector3 moveDirection = (wayPoint.transform.position - transform.position).normalized;
            transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(0, 0, 0);
        } 
    }
}
