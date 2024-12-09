using UnityEngine;

public class CheckActive : MonoBehaviour
{
   public void MustVisible()
    {
        if (gameObject.activeSelf)
            return;
        gameObject.SetActive(true);
    }
}
