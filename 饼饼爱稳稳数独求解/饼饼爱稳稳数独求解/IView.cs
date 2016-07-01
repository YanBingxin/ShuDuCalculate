using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 饼饼爱稳稳数独求解
{
    public interface IView
    {
        void Show();
        object DataContext { set; get; }

        void Close();
    }
}
