using PeZetSpiceBaseModels;
using SchematicSymbols.Elementary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchematicSymbols.MVVM
{
    public class BJT_VM : Rotable_VM<BJTModel>
    {
        public BJT_VM() : base(new BJTModel())
        {
            IsSelected = true;
        }
        public BJT_VM(BJTModel model) : base(model)
		{
            IsSelected = true;
        }

        public BJT_Polarity Polarity { get => polarity; set => SetValueProp(ref polarity, value); }
        private BJT_Polarity polarity;
    }
}
