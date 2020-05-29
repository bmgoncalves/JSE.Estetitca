using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JSE.Web.Extensions.Middleware
{
    /// <summary>
    /// Classe utilizada para substituir a chamada ValidateAntiForgeryToken dos controladores nos metodos
    /// do tipo POST
    /// </summary>
    public class ValidateAntiForgeryTokenMiddleware
    {
        private RequestDelegate _next;
        private IAntiforgery _antiforgery;

        public ValidateAntiForgeryTokenMiddleware(RequestDelegate next, IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            //Se o metodo for POST verificar o TOKEN
            if (HttpMethods.IsPost(context.Request.Method))
            {
                await _antiforgery.ValidateRequestAsync(context);
            }

            await _next(context);
        }



    }
}
