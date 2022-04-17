﻿using ComputersShopContracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputersShopBuisnessLogic.OfficePackage.HelperModels
{
    public class ExcelInfoWareHouse
    {
        public string FileName { get; set; }
        public string Title { get; set; }
        public List<ReportWareHouseComponentViewModel> WareHouseComponents { get; set; }
    }
}