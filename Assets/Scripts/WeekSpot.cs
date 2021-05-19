using UnityEngine;

public class WeekSpot : MonoBehaviour
{
    public GameObject objectToDestroy;
    public AudioClip killSound;

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Player"))
        {
          RandomManager.instance.lifeMustPop = RandomManager.instance.RandomTrueOrFalse(1- RandomManager.instance.difficulty);
          AudioManager.instance.PlayClipAt(killSound, transform.position);
          Destroy(objectToDestroy);
        }
    }
}
