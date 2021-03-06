using Chat_teste_.Core;
using Chat_teste_.MVVM.Model;
using System;
using System.Windows.Input;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_teste_.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public ObservableCollection<ModeloMenssagem> Menssagens { get; set; }
        public ObservableCollection<ModeloContatos> Contato { get; set; }

        //Comandos
        public RelayCommand SendCommand { get; set; }

        private ModeloContatos _contatoSelecionado;

        public ModeloContatos ContatoSelecionado
        {
            get { return _contatoSelecionado; }
            set 
            { 
                _contatoSelecionado = value;
                OnPropertyChanded();
            }
        }


        private string _menssagem;

        public string Menssagem
        {
            get { return _menssagem; }
            set 
            { 
                _menssagem = value;
                OnPropertyChanded();
            }
        }

        public MainViewModel()
        {
            Menssagens = new ObservableCollection<ModeloMenssagem>();
            Contato = new ObservableCollection<ModeloContatos>();

            SendCommand = new RelayCommand(o =>
            {
                Menssagens.Add(new ModeloMenssagem
                {
                    Menssagem = Menssagem,
                    PrimeiraMenssagem = false
                });

                Menssagem = "";
            });

            Menssagens.Add(new ModeloMenssagem
            {
                NomeUsuario = "Vitor",
                CorUsuario = "#409aff",
                ImageSource = "./Icons/GD.jpg",
                Menssagem= "Teste",
                Tempo = DateTime.Now,
                IsNativeOringin = false,
                PrimeiraMenssagem = true
            });
            for (int i = 0; i < 3; i++)
            {

                Menssagens.Add(new ModeloMenssagem
                {
                    NomeUsuario = "Vitor2",
                    CorUsuario = "#409aff",
                    ImageSource = "./Icons/GD.jpg",
                    Menssagem = "Teste",
                    Tempo = DateTime.Now,
                    IsNativeOringin = false,
                    PrimeiraMenssagem = false
                });
            }

            for (int i = 0; i < 4; i++)
            {

                Menssagens.Add(new ModeloMenssagem
                {
                    NomeUsuario = "Vitor3",
                    CorUsuario = "#409aff",
                    ImageSource = "",
                    Menssagem = "Teste",
                    Tempo = DateTime.Now,
                    IsNativeOringin = true,
                });
            }

            Menssagens.Add(new ModeloMenssagem
            {
                NomeUsuario = "Vitor3",
                CorUsuario = "#409aff",
                ImageSource = "./ViewModel/8b_2161_62348509a018b_min.jpeg",
                Menssagem = "Ultima",
                Tempo = DateTime.Now,
                IsNativeOringin = true,
            });

            for (int i = 0; i < 5; i++)
            {
                Contato.Add(new ModeloContatos
                {
                    NomeUsuario = $"Vitor{i}",
                    ImageSource = "https://cdn.icon-icons.com/icons2/788/PNG/512/user-1_icon-icons.com_65106.png",
                    Menssagens = Menssagens
                });

            }
        }

    }
}
