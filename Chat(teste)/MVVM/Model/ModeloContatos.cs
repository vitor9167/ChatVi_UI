using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_teste_.MVVM.Model
{
     class ModeloContatos
    {
        public string NomeUsuario { get; set; }
        public string ImageSource { get; set; }
        public ObservableCollection<ModeloMenssagem> Menssagens { get; set; }
        public string UltimaManssagem => Menssagens.Last().Menssagem;
    }
}
