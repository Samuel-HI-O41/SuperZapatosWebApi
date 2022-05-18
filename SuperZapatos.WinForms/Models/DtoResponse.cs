using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperZapatos.WinForms.Models
{
    public interface IResponse
    {
        bool Estado { get; set; }
        bool Caduca { get; set; }
        string Mensaje { get; set; }
        Exception Excepcion { get; set; }
        IStatus Icono { get; set; }
    }

    public enum IStatus { OK, ADVERTENCIA, PREGUNTA, INFORMACION, ERROR };

    [Serializable]
    public class DtoResponse<T> : IResponse
    {
        public T Resultado { get; set; }
        public bool Caduca { get; set; }
        public bool Estado { get; set; }
        public string Mensaje { get; set; }
        public Exception Excepcion { get; set; }
        public IStatus Icono { get; set; }

        public static implicit operator DtoResponse<T>(DtoResponse<List<string>> v)
        {
            throw new NotImplementedException();
        }
    }
}
