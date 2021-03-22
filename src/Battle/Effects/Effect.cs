using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipCore.Battle.Effects
{
    public abstract class Effect
    {
        protected bool _isActive;
        protected String _effect;
        protected EffectResolveTiming _resolveTiming;
        protected int _countdown;

        public Effect(EffectResolveTiming resolveTiming) 
        {
            _isActive = true;
            _effect = "NONE";
            _resolveTiming = resolveTiming;
        }

        public void ResolveEffect(EffectTarget effectTarget)
        {
            effectTarget.ResolveEffect();
        }

        public bool IsEffectActive() { return _isActive; }
        public String GetEffect() { return _effect; }
        public EffectResolveTiming GetResolveTiming() { return _resolveTiming; }

        public void DecreaseCountdown()
        {
            if (_isActive)
            {
                _countdown--;
                if (_countdown == 0) _isActive = false;
            }
        }

        public enum EffectResolveTiming
        {
            IMMEDIATE,
            ON_WALK,
            ON_HIT,
            ON_ATTACK
        }
    }
}
