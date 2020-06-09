using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TRPZ.User_Interface
{
    class ViewModel : INotifyPropertyChanged
    {
        IModel model;
        public ViewModel(IModel model)
        {
            this.model = model;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
