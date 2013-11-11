using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace T4Templates.Entities {

    public class AttributeHandler {
        public string Attributes(PropertyInfo prop) {
            //var attrs = System.Attribute.GetCustomAttributes(t);
            var attrs = prop.GetCustomAttributes();
            var list = new List<string>();
            foreach (Attribute attr in attrs) {
                if (attr is RequiredAttribute) {
                    RequiredAttribute r = (RequiredAttribute)attr;
                    list.Add("required: " + r.ErrorMessage);
                }
            }
            if (list.Any()) {
                return list.First();
            }
            else { return string.Empty; }
        }
        //public string PropertyAttributes(PropertyInfo prop) {
        //    prop.GetCustomAttributes
        //}
    }
}
