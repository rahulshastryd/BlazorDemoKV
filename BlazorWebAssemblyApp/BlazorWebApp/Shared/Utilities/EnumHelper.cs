using BlazorWebApp.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWebApp.Shared.Utilities
{
    public class EnumHelper
    {
        public static List<DropDownListItems> ConvertEnumToDropDownSource<T>(string initialText,string initialValue)
        {
            List<DropDownListItems> ret = new List<DropDownListItems>();
            var values = Enum.GetValues(typeof(T)).Cast<T>().ToList();
            if (!string.IsNullOrEmpty(initialValue) || !string.IsNullOrEmpty(initialText))
            {
                DropDownListItems ddlInitialItem = new DropDownListItems()
                {
                    Text = initialText,
                    Value = initialValue
                };
                ret.Add(ddlInitialItem);
            }
            for (int i = 0; i < Enum.GetNames(typeof(T)).Length; i++)
            {
                DropDownListItems ddlItem = new DropDownListItems();
                ddlItem.Text = Enum.GetNames(typeof(T))[i];
                ddlItem.Value = values[i].ToString();

                ret.Add(ddlItem);
            }

            return ret;
        }
    }
}
