﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciTopluluklari
{
    public class User
    {
        public string KullanıcıAdı { get; set; }
        public string Şifre { get; set; }
        public string TOPLULUKLAR    { get; set; }
        public string ETKİNLİKLER { get; set; }
        public string DUYURULAR { get; set; }
        public object YETKİ { get; internal set; }
    }
}

