using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChoreBoard.ViewModels
{
    public class MenuViewModel : Base.BaseViewModel
    {
        public override Task LoadData()
        {
            return Task.CompletedTask;
        }
    }
}
