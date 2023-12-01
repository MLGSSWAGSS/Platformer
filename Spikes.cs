using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        CharacterMove characterMove = collision.GetComponent<CharacterMove>();
        if (characterMove != null )
        {
            characterMove.ChangeHealth(-1);
        }
    }
}
