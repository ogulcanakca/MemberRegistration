using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibrary.Library.Core.Utilities.Mappings
{
    public class AutoMapperHelper
    {
        public static List<T> MapToSameTypeList<T>(List<T> list)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<T, T>();
            });

            List<T> result = cfg.CreateMapper().Map<List<T>, List<T>>(list);
            return result;
        }
        public static T MapToSameTypeType<T>(T obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<T, T>();
            });

            T result = cfg.CreateMapper().Map<T, T>(obj);
            return result;
        }

    }
}
