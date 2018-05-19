using UnityEngine;

public class obsticalrotator : MonoBehaviour
{ 
    void Update ()
        {
            transform.Rotate(new Vector3(0, 0, -90) * Time.deltaTime);
        }
}