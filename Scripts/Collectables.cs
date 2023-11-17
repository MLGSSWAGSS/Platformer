using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        CharacterMove characterMove = collision.GetComponent<CharacterMove>();
        if (characterMove != null)
        {
            Destroy(gameObject);
            characterMove.coinsCollected++;
            characterMove.itemText.text = "Coins Collected: " + characterMove.coinsCollected;
        }
    }
}
