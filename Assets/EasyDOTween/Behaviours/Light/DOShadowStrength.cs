//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EasyDOTween.Animation.Light
{
    using DG.Tweening;
    
    
    [UnityEngine.AddComponentMenu("EasyDOTween/Light/DOShadowStrength")]
    [UnityEngine.RequireComponent(typeof(UnityEngine.Light))]
    public class DOShadowStrength : EasyDOTween.Animation<UnityEngine.Light>
    {
        
        [UnityEngine.SerializeField()]
        private float endValue;
        
        protected override DG.Tweening.Tween CreateTween(UnityEngine.Light target, float duration)
        {
            return target.DOShadowStrength(endValue, duration);
        }
    }
}
