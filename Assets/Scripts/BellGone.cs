using UnityEngine;

public class BellGone : MonoBehaviour
{

    public AudioSource bell_gone_sound;
    public AudioClip bell_sound;
    private int bell_count;

    // 鐘にオブジェクトが衝突した際に実行される
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Stick")
        {
            bell_gone_sound.Play();
            BellCount();            
        }
    }

    void BellCount(){
        bell_count += 1;
        if(bell_count == 108){
            DeleteHumanDesires();
        }
    }

    void DeleteHumanDesires() {
        // TODO: bell_countが108になったときの処理を考える
    }
}
