using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace ModelConverter
{
    /// <summary>
    /// ModelConverter Class.
    /// </summary>
    /// <typeparam name="TObject">Model Class</typeparam>
    public class ModelConverter<TObject>
    {
        /// <summary>
        /// Convert System.Data.DataTable to System.Collections.Generic.List&gt;ModelClass&lt; object.
        /// </summary>
        /// <typeparam name="T">Model Class</typeparam>
        /// <param name="dt">System.Data.DataTable</param>
        /// <returns>System.Collections.Generic.List&lt;ModelClass&lt;</returns>
        public static List<T> GetModelList<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    T item = GetItem<T>(row);
                    data.Add(item);
                }
            }
            return data;
        }
        /// <summary>
        /// Get row into model properties.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dr"></param>
        /// <returns></returns>
        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, Convert.IsDBNull(dr[column.ColumnName]) ? null : dr[column.ColumnName]);
                    else
                        continue;
                }
            }
            return obj;
        }
         
        /// <summary>
        /// Convert the Model Class to IDictionary&lt;string&gt;, object&gt; object.
        /// </summary>
        /// <param name="o">Model Class</param>
        /// <param name="HiddenProperties">Hide the model class properties passing List&lt;string&gt; HiddenProperties object with model class property name to hide properties.</param>
        /// <returns>System.Collections.Generic.IDictionary&lt;string, object&gt;</returns>
        public static IDictionary<string, object> GetDictionary(TObject o, List<string> HiddenProperties = null)
        {
            IDictionary<string, object> res = new Dictionary<string, object>();
            PropertyInfo[] props = typeof(TObject).GetProperties();
            for (int i = 0; i < props.Length; i++)
            {
                if (props[i].CanRead)
                {
                    var caseInsensitiveDictionary = HiddenProperties != null && HiddenProperties.Count > 0 ? HiddenProperties.ConvertAll(h => h.ToLower()) : null;
                    if (caseInsensitiveDictionary != null && caseInsensitiveDictionary.Contains(props[i].Name.ToLower()))
                    {
                        continue;
                    }
                    else
                    {
                        res.Add(props[i].Name, o != null ? props[i].GetValue(o, null) : null);
                    }
                }
            }
            return res;
        }
    }
}
