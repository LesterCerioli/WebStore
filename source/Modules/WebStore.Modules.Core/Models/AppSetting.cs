﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStore.Infrastructure.Models;

namespace WebStore.Modules.Core.Models
{
    public class AppSetting : EntityBaseWithTypedId<string>
    {
        public AppSetting(string id)
        {
            Id = id;
        }

        [StringLength(450)]
        public string Value { get; set; }

        [StringLength(450)]
        public string Module { get; set; }

        public bool IsVisibleInCommonSettingPage { get; set; }
    }
}
