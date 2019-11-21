// MonoGame - Copyright (C) The MonoGame Team
// This file is subject to the terms and conditions defined in
// file 'LICENSE.txt', which is part of this source code package.

using Microsoft.Xna.Framework.Graphics;
using System;

namespace Microsoft.Xna.Framework.Content
{
    class EnvironmentMapEffectReader : ContentTypeReader<EnvironmentMapEffect>
    {
        protected internal override EnvironmentMapEffect Read(ContentReader input, EnvironmentMapEffect existingInstance)
        {
            var effect = new EnvironmentMapEffect(input.GraphicsDevice);
            effect.Texture = input.ReadExternalReference<Texture>() as Texture2D;
            effect.EnvironmentMap = input.ReadExternalReference<TextureCube>();
            effect.EnvironmentMapAmount = input.ReadSingle();
            effect.EnvironmentMapSpecular = input.ReadVector3();
            effect.FresnelFactor = input.ReadSingle();
            effect.DiffuseColor = input.ReadVector3();
            effect.EmissiveColor = input.ReadVector3();
            effect.Alpha = input.ReadSingle();
            return effect;
        }
    }
}
