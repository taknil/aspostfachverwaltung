using PaVe.InterfaceLayer.GUI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaVe.Utils
{
    [Serializable]
    public abstract class ClassIdentify
    {
        public long Id;
    }

    public static class StringExtensions
    {
        public static bool Contains(this string source, string value, StringComparison compareMode)
        {
            if (string.IsNullOrEmpty(source))
                return false;

            return source.IndexOf(value, compareMode) >= 0;
        }

        public static string RemoveWhitespace(this string value)
        {
            return new string(value.ToCharArray()
                .Where(c => !Char.IsWhiteSpace(c))
                .ToArray());
        }

        public static string ChangeExtension(this string value, string newExtension)
        {
            string extension = Path.GetExtension(value);
            string rawValue = value.Substring(0, value.IndexOf(extension));
            return newExtension.Contains('.') ? string.Concat(rawValue, newExtension) : string.Join(".", rawValue, newExtension);
        }
    }
    public static class CollectionExtensions
    {
        public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            HashSet<TKey> seenKeys = new HashSet<TKey>();
            foreach (TSource element in source)
                if (seenKeys.Add(keySelector(element)))
                    yield return element;
        }

        public static IEnumerable<TSource> GetElementsByID<TSource>(this IEnumerable<TSource> elements, long id) 
            where TSource : PaVe.Utils.ClassIdentify
        {
            return elements.Where(e => e.Id == id);
        }
    }
}
