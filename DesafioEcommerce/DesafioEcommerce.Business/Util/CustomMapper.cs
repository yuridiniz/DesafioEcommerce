using AutoMapper;
using AutoMapper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEcommerce.Business.Util
{
    public class CustomMapper
    {
        private static object lockObj = new object();

        public static void Configure()
        {
        }

        /// <summary>
        /// Converte um <see cref="TSource"/> para <see cref="TTarget"/>
        /// </summary>
        /// <returns></returns>
        public static TTarget Map<TSource, TTarget>(TSource source)
        {
            lock(lockObj)
            {
                Mapper.Initialize(cfg =>
                {
                    cfg.CreateMap<TSource, TTarget>();
                });

                var result = Mapper.Map<TSource, TTarget>(source);
                return result;
            }
        }

        /// <summary>
        /// Converte uma lista de <see cref="TSource"/> para uma lista de <see cref="TTarget"/>
        /// </summary>
        /// <returns></returns>
        public static List<TTarget> Map<TSource, TTarget>(List<TSource> lstSource)
        {
            lock (lockObj)
            {
                var listResult = new List<TTarget>();

                Mapper.Initialize(cfg =>
                {
                    cfg.CreateMap<TSource, TTarget>();
                });

                foreach (var source in lstSource)
                    listResult.Add(Mapper.Map<TSource, TTarget>(source));

                return listResult;
            }
        }
    }
}
