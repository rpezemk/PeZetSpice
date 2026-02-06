
using System.Windows.Input;

namespace BasicWpfHelpers
{
    public static class MouseHelper
    {
        public static class Only
        {
            public static bool Left() => GetPressed() == (true, false, false);
            public static bool Middle() => GetPressed() == (false, true, false);
            public static bool Right() => GetPressed() == (false, false, true);
        }

        public static (bool left, bool middle, bool right) GetPressed()
        {
            return (IsLeft(), IsMiddle(), IsRight());
        }

        public static bool IsLeft() =>   Pressed(Mouse.LeftButton);
        public static bool IsMiddle() => Pressed(Mouse.MiddleButton);
        public static bool IsRight() =>  Pressed(Mouse.RightButton);
        public static bool Pressed(MouseButtonState state) => state == MouseButtonState.Pressed;

    }

}
