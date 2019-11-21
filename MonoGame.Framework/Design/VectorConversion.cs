using Microsoft.Xna.Framework.Graphics.PackedVector;
using System;
using System.ComponentModel;
using System.Globalization;

namespace Microsoft.Xna.Framework.Design
{
    internal static class VectorConversion
    {
        public static bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return (destinationType == typeof(float) ||
                destinationType == typeof(Vector2) ||
                destinationType == typeof(Vector3) ||
                destinationType == typeof(Vector4) ||
                destinationType.GetInterface("IPackedVector") != null);
        }

        public static object ConvertToFromVector4(ITypeDescriptorContext context,
                                                  CultureInfo culture,
                                                  Vector4 value,
                                                  Type destinationType)
        {
            switch(destinationType.Name)
            {
                case "float":
                    return value.X;
                case "Vector2":
                    return new Vector2(value.X, value.Y);
                case "Vector3":
                    return new Vector3(value.X, value.Y, value.Z);
                case "Vector4":
                    return new Vector4(value.X, value.Y, value.Z, value.W);
                default:
                    if(destinationType.GetInterface("IPackedVector") != null)
                    {
                        var packedVec = (IPackedVector)Activator.CreateInstance(destinationType);
                        packedVec.PackFromVector4(value);
                        return packedVec;
                    }
                    return null;
            }
        }
    }
}
