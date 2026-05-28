using UnityEngine;

public class OldManFaint : MonoBehaviour
{
    private bool isFainting = false;
    private float speed = 2f;
    private Quaternion targetRotation;

    void Start()
    {
        targetRotation = Quaternion.Euler(90f, 0f, 0f);
        Invoke("StartFaint", 2f);
    }

    void StartFaint()
    {
        isFainting = true;
    }

    void Update()
    {
        if (isFainting)
        {
            transform.rotation = Quaternion.Lerp(
                transform.rotation,
                targetRotation,
                Time.deltaTime * speed
            );

            if (Quaternion.Angle(transform.rotation, targetRotation) < 1f)
            {
                isFainting = false;
            }
        }
    }
}