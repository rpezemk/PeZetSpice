using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeZetSpiceBaseModels
{
    public static class RotationEnumExtensions
    {
        public static (bool flipped, RotationEnum rotEnum) FlipVertically(this RotationEnum rotation, bool flipped)
        {
            return (flipped, rotation);
        }

        public static (bool flipped, RotationEnum rotEnum) FlipHorizontally(this RotationEnum rotation, bool flipped)
        {
            var resRot = rotation.RotateClockwise().RotateClockwise();
            return (flipped, resRot);
        }

        public static RotationEnum RotateCounterClockwise(this RotationEnum rotation)
        {
            var newRot = rotation switch
            {
                RotationEnum.None_0 => RotationEnum.ThreeQuarter_270,
                RotationEnum.Quarter_90 => RotationEnum.None_0,
                RotationEnum.Half_180 => RotationEnum.Quarter_90,
                RotationEnum.ThreeQuarter_270 => RotationEnum.Half_180,
                _ => throw new ArgumentOutOfRangeException(nameof(rotation), $"Unexpected rotation value: {rotation}")
            };
            return newRot;
        }
        public static RotationEnum RotateClockwise(this RotationEnum rotation)
        {
            var newRot = rotation switch
            {
                RotationEnum.None_0 => RotationEnum.Quarter_90,
                RotationEnum.Quarter_90 => RotationEnum.Half_180,
                RotationEnum.Half_180 => RotationEnum.ThreeQuarter_270,
                RotationEnum.ThreeQuarter_270 => RotationEnum.None_0,
                _ => throw new ArgumentOutOfRangeException(nameof(rotation), $"Unexpected rotation value: {rotation}")
            };
            return newRot;
        }

        public static double ToDegrees(this RotationEnum rotation)
        {
            return rotation switch
            {
                RotationEnum.None_0 => 0,
                RotationEnum.Quarter_90 => 90,
                RotationEnum.Half_180 => 180,
                RotationEnum.ThreeQuarter_270 => 270,
                _ => throw new ArgumentOutOfRangeException(nameof(rotation), $"Unexpected rotation value: {rotation}")
            };
        }
    }

    public enum RotationEnum
    {
        None_0,
        Quarter_90,
        Half_180,
        ThreeQuarter_270
    }    
}
