﻿using Data.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Data
{
    public class DataContext
    {

        /// <summary>
        /// شی مربوط به پایگاه داده
        /// </summary>
        public static Entities Context
        {
            get
            {
                try
                {
                    if (HttpContext.Current == null)
                        return new Entities();

                    var ocKey = "ocm_" + HttpContext.Current.GetHashCode().ToString("x");
                    if (!HttpContext.Current.Items.Contains(ocKey))
                        HttpContext.Current.Items.Add(ocKey, new Entities());
                    return HttpContext.Current.Items[ocKey] as Entities;
                }
                catch
                {
                    throw;
                }
            }
        }
    }
}
