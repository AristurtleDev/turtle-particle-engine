﻿// Released under The Unlicense.
// See LICENSE file in the project root for full license information.
// License information can also be found at https://unlicense.org/.

using Aristurtle.ParticleEngine.Data;

namespace Aristurtle.ParticleEngine.Modifiers;

public class RotationModifier : Modifier
{
    public float RotationRate;

    public override unsafe void Update(float elapsedSeconds, Particle* particle, int count)
    {
        float rotationRateDelta = RotationRate * elapsedSeconds;

        while (count-- > 0)
        {
            particle->Rotation += rotationRateDelta;
            particle++;
        }
    }
}
