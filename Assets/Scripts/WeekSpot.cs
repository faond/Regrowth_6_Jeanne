using UnityEngine;

public class WeekSpot : MonoBehaviour
{
    public GameObject objectToDestroy;
    public AudioClip killSound;

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Player"))
        {
          RandomManager.instance.lifeMustPop = (RandomManager.instance.Uniform(0,1) == 1);
          AudioManager.instance.PlayClipAt(killSound, transform.position);
          Destroy(objectToDestroy);
        }
    }
}
