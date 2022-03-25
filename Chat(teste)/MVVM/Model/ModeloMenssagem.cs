using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_teste_.MVVM.Model
{
    class ModeloMenssagem
    {
        public string NomeUsuario { get; set; }
        public string CorUsuario { get; set; }
        public string ImageSource { get; set; }
        public string Menssagem { get; set; }
        public DateTime Tempo { get; set; }
        public bool IsNativeOringin { get; set; }
        public bool PrimeiraMenssagem { get; set; }
    }
}
