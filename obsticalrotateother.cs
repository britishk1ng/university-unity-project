using UnityEngine;

public class obsticalrotateother : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 90) * Time.deltaTime);
    }
}