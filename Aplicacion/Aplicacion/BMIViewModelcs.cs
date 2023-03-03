using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Aplicacion
{
    internal class BMIViewModelcs : INotifyPropertyChanged
    {
        private double height = 180;
        private double weight = 72;
        private const double STEP = 1.0;

    public double Height
    {
        get => height;
        set
        {
            height = NextStep(value);
            UpdateResults();
        }
    }

    public double Weight
    {
        get => weight;
        set
        {
            weight = NextStep(value);
            UpdateResults();
        }
    }

    public double Bmi
        => Math.Round(Weight / Math.Pow(Height / 100, 2), 2);

    public string Classification
    {
        get
        {
            if (Bmi < 18.5)
                return "Estas de Bajo peso";
            else if (Bmi < 25)
                return "Tienes peso Normal";
            else if (Bmi < 30)
                return "Estas de Sobre peso";
            else
                return "Tienes Obesidad";
        }
    }

    private void UpdateResults()
    {
        RaisePropertyChanged(nameof(Bmi));
        RaisePropertyChanged(nameof(Classification));
    }

    private double NextStep(double value)
        => Math.Round(value / STEP) * STEP;

    private void RaisePropertyChanged(string propertyName)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    public event PropertyChangedEventHandler PropertyChanged;
}
}
