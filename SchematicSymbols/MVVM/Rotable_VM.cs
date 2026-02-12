using BasicWpfHelpers.ViewModel;
using PeZetSpiceBaseModels;
using SchematicSymbols.Elementary;

namespace SchematicSymbols.MVVM
{
    public class Rotable_VM : ViewModelBase<BaseElementModel>
    {
        public Rotable_VM(BaseElementModel model) : base(model)
        {

        }

        public void RotateClockwise()
        {
            Model.Rotation = Model.Rotation.RotateClockwise();
            RotationAngle = Model.Rotation.ToDegrees();
        }
        public bool IsSelected { get => isSelected; set => base.SetValueProp(ref isSelected, value); }
        private bool isSelected;
        public double RotationAngle { get => rotationAngle; set => base.SetValueProp(ref rotationAngle, value); }
        private double rotationAngle;
    }
    public class Rotable_VM<T> : Rotable_VM where T : BaseElementModel
    {
        public Rotable_VM(T model) : base(model)
        {

        }

        public void RotateClockwise()
        {
            Model.Rotation = Model.Rotation.RotateClockwise();
            RotationAngle = Model.Rotation.ToDegrees();
        }
    }
}
