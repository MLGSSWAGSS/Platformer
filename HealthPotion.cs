using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        CharacterMove characterMove = collision.GetComponent<CharacterMove>();
        if (characterMove != null && characterMove.CanCollectHealth())
        {
            Destroy(gameObject);
            characterMove.ChangeHealth(1);
        }
    }
}
