using System;

namespace Services.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Usuario { get; set; }

        public string Senha { get; set; }

        public string Nome { get; set; }

        public DateTime ValidadeSenha { get; set; }

        public UserDTO() { }

        public UserDTO(int id, string usuario, string senha, string nome, DateTime validadeSenha)
        {
            Id = id;
            Usuario = usuario;
            Senha = senha;
            Nome = nome;
            ValidadeSenha = validadeSenha;
        }
    }
}
