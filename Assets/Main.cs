using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;

[RequireComponent(typeof(Animator))]
public class Main : MonoBehaviour
{
    [SerializeField]
    private AnimationClip _clip;

    [SerializeField]
    private ParticleSystem _p;

    void Start()
    {
        var g = PlayableGraph.Create();
        var clipPlayable = AnimationClipPlayable.Create(g, _clip);
        var output = AnimationPlayableOutput.Create(g, "output", GetComponent<Animator>());
        output.SetSourcePlayable(clipPlayable);
        g.Play();
        _p.Play();
    }
}
