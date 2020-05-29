using Microsoft.AspNetCore.Http;
using System;

namespace JSE.Web.Extensions.SessaoUsuario
{
    public class Sessao
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public Sessao(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }
        public void Cadastrar(string key, string valor)
        {
            _contextAccessor.HttpContext.Session.SetString(key, valor);
        }

        public void Atualizar(string key, string valor)
        {
            if (Existe(key))
            {
                _contextAccessor.HttpContext.Session.Remove(key);
            }
            _contextAccessor.HttpContext.Session.SetString(key, valor);

        }

        public void Remover(string key)
        {
            _contextAccessor.HttpContext.Session.Remove(key);
        }

        public String Consultar(string key)
        {
            return _contextAccessor.HttpContext.Session.GetString(key);
        }

        public bool Existe(string key)
        {
            if (_contextAccessor.HttpContext.Session.GetString(key) == null)
            {
                return false;
            }

            return true;
        }

        public void RemoverTodos()
        {
            _contextAccessor.HttpContext.Session.Clear();
        }
    }
}
