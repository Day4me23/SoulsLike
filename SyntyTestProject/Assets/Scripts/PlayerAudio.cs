using UnityEngine.Audio;
using UnityEngine;

public class PlayerAudio : MonoBehaviour
{
    [SerializeField]
    private AudioClip[] clips;
    public AudioClip roll;
    public AudioClip lightatk;
    public AudioClip heavyatk;
    public AudioClip land;
    public AudioClip heal;
    public AudioClip equip;

    private AudioSource audioSource;
    

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
       
    }

    public void Step(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5 && !PlayerStateManager.instance.isInteracting)
        {
            AudioClip clip = GetRandomClip();
            audioSource.PlayOneShot(clip, volumeScale: 0.5f);
        }
    }


    public void Roll(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5)
        {
            
            audioSource.PlayOneShot(roll);
        }
    }

    public void LightAtk(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5)
        {

            audioSource.PlayOneShot(lightatk);
        }
    }

    public void HeavyAtk(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5)
        {

            audioSource.PlayOneShot(heavyatk);
        }
    }

    public void Heal(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5)
        {

            audioSource.PlayOneShot(heal);
        }
    }

    public void Land(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5)
        {

            audioSource.PlayOneShot(land);
        }
    }
    public void Equip() {
        audioSource.PlayOneShot(equip);
    }
    private AudioClip GetRandomClip()
    {
        return clips[UnityEngine.Random.Range(0, clips.Length)];
    }


}
