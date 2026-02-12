using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchematicSymbols.Elementary
{
    public interface ISelectable
    {
        bool IsSelected { get; set; }
        void Select();
    }
}
