using JSE.Web.Extensions.SessaoUsuario;
using JSE.Web.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JSE.Web.Extensions.Login
{
    public class LoginUsuario
    {
        private readonly string key = "Login.Usuario";
        private readonly Sessao _sessao;
        public LoginUsuario(Sessao sessao)
        {
            _sessao = sessao;
        }

        public void Login(Usuario usuario)
        {
            string usuarioJson = JsonConvert.SerializeObject(usuario);
            _sessao.Cadastrar(key, usuarioJson);
        }

        public Usuario GetUsuario()
        {

            if (_sessao.Existe(key))
            {
                string usuarioJson = _sessao.Consultar(key);
                return JsonConvert.DeserializeObject<Usuario>(usuarioJson);
            }
            else
            {
                return null;
            }
        }

        public void Logout()
        {
            _sessao.RemoverTodos();
        }


    }
}
