using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_App
{
    public class JuntaNombre : INotifyPropertyChanged
    {
        private string? _nombre, _apellido, _nombreCompleto;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string? Nombre
        { 
            get { return _nombre; }
            set
            { 
                _nombre = value; 
                OnPropertyChanged(nameof(NombreCompleto));
            }         
        }

        public string? Apellido
        {
            get { return _apellido; }
            set
            {
                _apellido = value;
                OnPropertyChanged(nameof(NombreCompleto));
            }
        }

        public string? NombreCompleto
        {
            get { return _nombre + " " + _apellido; }
            set
            {
                _nombreCompleto = value;
                OnPropertyChanged(nameof(NombreCompleto));
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            //if (PropertyChanged != null)
            //{
            //    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            //}
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
