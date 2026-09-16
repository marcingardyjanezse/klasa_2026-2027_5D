using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MauiApp9
{
    public class Calculator : BindableObject
    {
        public float ValueA
        {
            get => field;
            set
            {
                field = value;
                OnPropertyChanged(nameof(Result));
            }
        }

        public float ValueB
        {
            get => field;
            set
            {
                field = value;
                OnPropertyChanged(nameof(Result));
            }
        }

        public float Result
        {
            get
            {
                return ValueA + ValueB;
            }
        }

    }
}
