using Dots.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dots.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        //Properties

        #region Message
        private string _Message = "Dots!";

        public string Message
        {
            get => _Message;
            set => Set(ref _Message, value);
        }
        #endregion


    }
}
