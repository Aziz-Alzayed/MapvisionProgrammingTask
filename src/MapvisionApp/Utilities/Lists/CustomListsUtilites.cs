using System.Reflection;

namespace MapvisionApp.Utilities.Lists
{
    public static class CustomListsUtilites
    {
        /// <summary>
        /// Search in all properties inside a model.
        /// </summary>
        /// <typeparam name="T">Type of class.</typeparam>
        /// <returns></returns>
        public static List<T> SearchAllProperties<T>(this List<T> list, string searchTerm)
        {
            var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            return list.Where(item =>
            {
                foreach (var property in properties)
                {
                    var value = property.GetValue(item)?.ToString();
                    if (value != null && value == searchTerm)
                    {
                        return true;
                    }
                }
                return false;
            }).ToList();
        }
    }
}
