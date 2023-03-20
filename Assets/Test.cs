using UnityEngine;
using System.Collections.Generic;

public class Test : MonoBehaviour
{
    private void Start()
    {
        //Windows中文測試
        //Ｍac顯示正常
    }



    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.TryGetComponent(out SpriteRenderer spriteRenderer))
        {
            Debug.Log(spriteRenderer.transform.position.y);
            if (spriteRenderer.transform.position.y > transform.position.y)
            {
                spriteRenderer.sortingOrder = 0;
                return;
            }
            spriteRenderer.sortingOrder = 2;
        }
    }
}
