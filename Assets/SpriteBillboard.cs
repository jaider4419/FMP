using UnityEngine;

public class SpriteBillboard : MonoBehaviour
{

    public Camera maincam;

    public void LateUpdate()
    {
        transform.rotation = Quaternion.Euler(0f, Camera.main.transform.rotation.eulerAngles.y, 0f);
    }
}
