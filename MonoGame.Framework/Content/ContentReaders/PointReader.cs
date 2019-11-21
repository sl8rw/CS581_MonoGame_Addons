// MonoGame - Copyright (C) The MonoGame Team
// This file is subject to the terms and conditions defined in
// file 'LICENSE.txt', which is part of this source code package.

using System;

namespace Microsoft.Xna.Framework.Content
{
    internal class PointReader : ContentTypeReader<Point>
    {
        public PointReader() { }

        protected internal override Point Read(ContentReader input, Point existingInstance)
        {
            int X = input.ReadInt32();
            int Y = input.ReadInt32();
            return new Point(X, Y);
        }
    }
}
