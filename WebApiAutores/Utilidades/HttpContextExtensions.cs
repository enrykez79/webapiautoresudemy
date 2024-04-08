﻿using Microsoft.EntityFrameworkCore;

namespace WebApiAutores.Utilidades
{
    public static class HttpContextExtensions
    {
        public async static Task InsertarParametrosPaginacionEnCabecera<T>(this HttpContext httpContext,
            IQueryable<T> queryable)
        {
            if (httpContext == null) { throw new ArgumentNullException(nameof(httpContext)); }

            double cantidad = await queryable.CountAsync();
            //httpContext.Response.Headers.Add("cantidadTotalRegistros", cantidad.ToString());
            httpContext.Response.Headers["cantidadTotalRegistros"] = cantidad.ToString();
        }

    }
}