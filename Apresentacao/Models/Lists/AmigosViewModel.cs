using Dominio;
using System.Collections.Generic;

namespace Apresentacao.Models.Lists
{
    public class AmigosViewModel
    {
        public static string[] AmigosSelecionados { get; set; } = new string[1]; //inicializado por 1 porque não pode ser nulo
        public static string[] Amigos2Selecionados { get; set; } = new string[1];
        public List<Amigo> Amigos { get; set; } = new List<Amigo>();
    }
}
