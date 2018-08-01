using UnityEngine;

public class Screenshot : MonoBehaviour
{
    void OnMouseDown()
    {
        ScreenCapture.CaptureScreenshot("Image.png");
        Debug.Log("Something should have happened");
    }
}